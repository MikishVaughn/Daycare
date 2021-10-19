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

        If HttpContext.Current.Request.IsLocal Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "Waterloo Bulldog Wrestling Club"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "https://mikish.com"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "MikishVaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://www.facebook.com/groups/2282063028779306"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/place/Waterloo+High+School/@38.319154,-90.1398618,15z/data=!4m5!3m4!1s0x0:0x72f2d8598a2c843a!8m2!3d38.319154!4d-90.1398618"
            End If
            If AttributeName = "LinkShare" Then
                Return "~/Content/Images/Site/LinkShares/linkshare-01"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to the Bulldog Wrestlers!"
            End If
        End If
        If siteURL.Contains("Bulldog") Or siteURL.Contains("bulldog.") Then
            If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
                Return "Waterloo Bulldog Wrestling Club"
            End If
            If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
                Return "https://mikish.com"
            End If
            If AttributeName = "SiteEmail_Sales" Then
                Return "Mikish.Vaughn@Gmail.com"
            End If
            If AttributeName = "SiteEmail_Support" Then
                Return "Mikish.Vaughn@Gmail.com"
            End If
            If AttributeName = "SiteFacebookPageURL" Then
                Return "https://www.facebook.com/groups/2282063028779306"
            End If
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/place/Waterloo+High+School/@38.319154,-90.1398618,15z/data=!4m5!3m4!1s0x0:0x72f2d8598a2c843a!8m2!3d38.319154!4d-90.1398618"
            End If
            If AttributeName = "LinkShare" Then
                Return "~/Content/Images/Site/LinkShares/linkshare-01.png"
            End If
            If AttributeName = "SiteDescription" Then
                Return "This web site is dedicated to the Bulldog Wrestlers!"
            End If
        End If
        If AttributeName = "SiteName" Or AttributeName = "SiteDesigner" Then
            Return "The Mikish Group"
        End If
        If AttributeName = "SiteURL" Or AttributeName = "SiteDesignerURL" Then
            Return "https://mikish.com"
        End If
        If AttributeName = "SiteEmail_Sales" Then
            Return "MikishVaughn@Gmail.com"
        End If
        If AttributeName = "SiteEmail_Support" Then
            Return "MikishVaughn@Gmail.com"
        End If
        If AttributeName = "SiteFacebookPageURL" Then
            Return "https://Facebook.com/MikishGroup"
        End If
        If AttributeName = "SiteGoogleMapURL" Then
            Return "https://www.google.com/maps/dir//39.1879094,-89.9457662/@39.1860534,-89.9462016,1009m/data=!3m1!1e3"
        End If
        If AttributeName = "LinkShare" Then
            Return "~/Content/Images/Site/LinkShares/TheMikishGroup_Welcome_1200x630.jpg"
        End If
        If AttributeName = "SiteDescription" Then
            Return "This web site is dedicated to The Mikish Group!"
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

        If Msg = "EventsMenu" Then
            Msg = "Countdowns"
        End If

        Dim imageCount As Integer = 1
        Try
            If HttpContext.Current.Request.IsLocal Then
                imageCount = IO.Directory.GetFiles("D:\Projects\Repos\MyWebsite\Content\Images\Categories\" + Msg, "*.jpg").Length()
            Else
                imageCount = IO.Directory.GetFiles("h:\root\home\mikish-001\www\site1\Content\Images\Categories\" + Msg, "*.jpg").Length()
                Try
                    imageCount = IO.Directory.GetFiles("h:\root\home\mikish-001\www\site1\Content\Images\Categories\" + Msg, "*.jpg").Length()
                Catch ex As Exception
                    imageCount = IO.Directory.GetFiles("G:\PleskVhosts\mikish.com\httpdocs\Content\Images\Categories\" + Msg, "*.jpg").Length()
                End Try

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