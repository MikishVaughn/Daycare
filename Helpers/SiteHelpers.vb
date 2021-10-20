Public Class SiteHelpers

    ' GetImageLocation 
    '********************
    '
    <AllowAnonymous>
    Public Shared Function GetImageLocation() As String

        Dim ImageLocation As String = "~/Content/Images/"
        If HttpContext.Current.Request.IsLocal Then
            ImageLocation = "/Content/Images/"
        End If

        Return ImageLocation

    End Function
    ' GetSiteInfo      
    '********************
    '
    ' Get Site Info for correct domain
    '
    ' Some unique site info is stored below and is determined by the RootURL().
    ' This is a pretty basic way to make sites dynamic based on what web address is viewing the site.
    '
    <AllowAnonymous>
    Public Shared Function GetSiteInfo(AttributeName As String) As String

        Dim siteURL As String = RootUrl()

        ' Site Designer
        If AttributeName = "SiteDesigner" Then
            Return "The Mikish Group"
        End If
        If AttributeName = "SiteDesignerURL" Then
            Return "https://mikish.com"
        End If

        ' Site Specific Info:

        '' Running Local
        '' (Show Bulldog) 
        If HttpContext.Current.Request.IsLocal Then

            ' Site Name
            If AttributeName = "SiteName" Then
                Return "Waterloo Bulldog Wrestling Club"
            End If

            ' Site Description
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to the Bulldog Wrestlers!"
            End If

            ' Site URL
            If AttributeName = "SiteURL" Then
                Return "http://mikish-001-site2.gtempurl.com/"
            End If

            ' Site Email
            If AttributeName = "SiteEmailSales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmailSupport" Then
                Return "MikishVaughn@Gmail.com"
            End If

            ' Facebook Page
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://www.facebook.com/groups/2282063028779306"
            End If

            ' Google Maps Location
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/@38.3357011,-90.1490775,4135m/data=!3m1!1e3"
            End If

            ' Site Images
            If AttributeName = "BigLogo" Then
                Return "/Content/Images/Site/Catagories/Svg/BD-Body-01.svg"
            End If
            If AttributeName = "SmallLogo" Then
                Return "/Content/Images/Site/Catagories/Svg/BD-Head-Right-03.svg"
            End If
            If AttributeName = "PageImage_About" Then
                Return "/Content/Images/Site/Catagories/PageImages/900x800-image-01.jpg"
            End If
            If AttributeName = "LinkShare" Then
                Return "/Content/Images/Site/Catagories/LinkShares/1200x630-linkshare-01"
            End If

        End If

        '' URL contains "Bulldog"
        If siteURL.Contains("Bulldog") Or siteURL.Contains("bulldog") Then

            ' Site Name
            If AttributeName = "SiteName" Then
                Return "Waterloo Bulldog Wrestling Club"
            End If

            ' Site Description
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to the Bulldog Wrestlers!"
            End If

            ' Site URL
            If AttributeName = "SiteURL" Then
                Return "http://mikish-001-site2.gtempurl.com/"
            End If

            ' Site Email
            If AttributeName = "SiteEmailSales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmailSupport" Then
                Return "MikishVaughn@Gmail.com"
            End If

            ' Facebook Page
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://www.facebook.com/groups/2282063028779306"
            End If

            ' Google Maps Location
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/@38.3357011,-90.1490775,4135m/data=!3m1!1e3"
            End If

            ' Site Images
            If AttributeName = "BigLogo" Then
                Return "/Content/Images/Site/Catagories/Svg/BD-Body-01.svg"
            End If
            If AttributeName = "SmallLogo" Then
                Return "/Content/Images/Site/Catagories/Svg/BD-Head-Right-03.svg"
            End If
            If AttributeName = "PageImage_About" Then
                Return "/Content/Images/Site/Catagories/PageImages/900x800-image-01.jpg"
            End If
            If AttributeName = "LinkShare" Then
                Return "/Content/Images/Site/Catagories/LinkShares/1200-630-linkshare-01"
            End If
        End If

        ' Site URL not Local and name not caught for specific settings
        ' so use the default site info below:

        ' Site Name
        If AttributeName = "SiteName" Then
            Return "The Mikish Group"
        End If

        ' Site Description
        If AttributeName = "SiteDescription" Then
            Return "This web site is dedicated to the The Mikish Group!"
        End If

        ' Site URL
        If AttributeName = "SiteURL" Then
            Return "http://mikish-001-site1.gtempurl.com/"
        End If

        ' Site Email
        If AttributeName = "SiteEmailSales" Then
            Return "MikishVaughn@Gmail.com"
        End If
        If AttributeName = "SiteEmailSupport" Then
            Return "MikishVaughn@Gmail.com"
        End If

        ' Facebook Page
        If AttributeName = "SiteFacebookPageURL" Then
            Return "https://Facebook.com/MikishGroup"
        End If

        ' Google Maps Location
        If AttributeName = "SiteGoogleMapURL" Then
            Return "https://www.google.com/maps/@38.992257,-89.1196202,286m/data=!3m1!1e3"
        End If

        ' Site Images
        If AttributeName = "BigLogo" Then
            Return "/Content/Images/Catagories/Site/Svg/BlueSun.svg"
        End If
        If AttributeName = "SmallLogo" Then
            Return "/Content/Images/Site/Catagories/Svg/BlueSun.svg"
        End If
        If AttributeName = "PageImage_About" Then
            Return "/Content/Images/Site/Catagories/PageImages/900x800-image-02.jpg"
        End If
        If AttributeName = "LinkShare" Then
            Return "/Content/Images/Site/Catagories/LinkShares/1200x630-linkshare-02"
        End If

        'If we make it here then there was a coding failure!
        Return "Oops!" ' :-(

    End Function
    ' RootURL()        
    '********************
    '
    ' Used to return the Root URL to determine the site address and therefore identity.
    '
    <AllowAnonymous>
    Public Shared Function RootUrl() As String
        Return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/")
    End Function
    ' MaxImages() 
    '********************
    '
    ' Returns the image count in an image folder.
    '
    <AllowAnonymous>
    Public Shared Function MaxImages(Msg As String) As Integer

        Dim imageCount As Integer = 1
        Try
            If HttpContext.Current.Request.IsLocal Then
                imageCount = IO.Directory.GetFiles("D:\Projects\Repos\Bulldog\Content\Images\Categories\" + Msg, "*.jpg").Length()
            Else
                imageCount = IO.Directory.GetFiles("h:\root\home\mikish-001\www\site2\Content\Images\Categories\" + Msg, "*.jpg").Length()
                Try
                    imageCount = IO.Directory.GetFiles("h:\root\home\mikish-001\www\site1\Content\Images\Categories\" + Msg, "*.jpg").Length()
                Catch ex As Exception
                    imageCount = IO.Directory.GetFiles("G:\PleskVhosts\mikish.com\httpdocs\Content\Images\Categories\" + Msg, "*.jpg").Length()
                End Try

                '' For Info Purposes:
                ''
                '' GoDaddy.com
                '' imageCount = IO.Directory.GetFiles("G:\PleskVhosts\mikish.com\httpdocs\Content\Images\Categories\" + Msg, "*.jpg").Length()

                '' MyAsp.net
                '' imageCount = IO.Directory.GetFiles("h:\root\home\mikish-001\www\site1\Content\Images\Categories\" + Msg, "*.jpg").Length()

            End If
        Catch ex As Exception
            MsgBox("Image Directory Not Found", MsgBoxStyle.Critical)
            Return imageCount
        End Try

        Return imageCount

    End Function

    ' Overrides   
    '********************
    '
    ' Additional Class Functions
    '
    Public Sub New()
    End Sub
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Return MyBase.Equals(obj)
    End Function
    Public Overrides Function GetHashCode() As Integer
        Return MyBase.GetHashCode()
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class