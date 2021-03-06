Public Class SiteHelpers

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

        Dim siteURL As String = LCase(RootUrl())

        ' Site Designer
        If AttributeName = "SiteDesigner" Then
            Return "The Mikish Group"
        End If
        If AttributeName = "SiteEmailDesigner" Then
            Return "Mikish.Vaughn@Gmail.com"
        End If
        If AttributeName = "SiteDesignerURL" Then
            Return "https://mikish.com"
        End If
        If AttributeName = "SiteDesignerLogo" Then
            Return "/Content/Images/Site/Catagories/Svg/BlueSun.svg"
        End If

        '' Running Local
        '' (Show Dayare) 
        If HttpContext.Current.Request.IsLocal Or siteURL.Contains("daycare") Then

            ' Site Name
            If AttributeName = "SiteName" Then
                Return "The Daycare Center"
            End If
            If AttributeName = "SiteNameShort" Then
                Return "The Daycare Center"
            End If

            ' Site Description
            If AttributeName = "SiteDescription" Then
                Return "This web site is to provide information on The Daycare Center."
            End If

            ' Site URL
            If AttributeName = "SiteURL" Then
                Return "http://Daycare.illustrate.net"
            End If

            ' Site Contact
            If AttributeName = "SiteContact" Then
                Return "Heidi McCullough"
            End If

            ' Site Address
            If AttributeName = "Address1" Then
                Return "8 WILLOUGHBY CT"
            End If
            If AttributeName = "Address2" Then
                Return "ALGONQUIN IL 60102"
            End If

            ' Phone
            If AttributeName = "Phone1" Then
                Return "(847) 845-6410"
            End If

            ' Site Email
            If AttributeName = "SiteEmailContact" Then
                Return "none@none.com"
            End If

            ' Site Sales and Support
            If AttributeName = "SiteEmailSales" Then
                Return "none@none.com"
            End If
            If AttributeName = "SiteEmailSupport" Then
                Return "Mikish.Vaughn@Gmail.com"
            End If

            ' Facebook Page
            If AttributeName = "SiteFacebookPageURL" Then
                Return ""
            End If

            ' Google Maps Location
            If AttributeName = "SiteGoogleMapURL" Then
                Return "https://www.google.com/maps/place/8+Willoughby+Ct,+Algonquin,+IL+60102/@42.14977,-88.320628,16z/data=!4m5!3m4!1s0x880f0dfecc67645d:0x46cd813aa7f413!8m2!3d42.1497696!4d-88.3206282?hl=en-US"
            End If

            ' Site Images
            If AttributeName = "BigLogo" Then
                Return "/Content/Images/Site/Catagories/Svg/BlueSun.svg"
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

        End If

        ' Site URL not Local and name not caught for specific settings
        ' so use the default site info below:

        ' Site Name
        If AttributeName = "SiteName" Then
            Return "The Daycare Center"
        End If
        If AttributeName = "SiteNameShort" Then
            Return "The Daycare Center"
        End If

        ' Site Description
        If AttributeName = "SiteDescription" Then
            Return "This web site is to provide information on The Daycare Center."
        End If

        ' Site URL
        If AttributeName = "SiteURL" Then
            Return "http://Daycare.illustrate.net"
        End If

        ' Site Contact
        If AttributeName = "SiteContact" Then
            Return "Heidi McCullough"
        End If

        ' Site Address
        If AttributeName = "Address1" Then
            Return "8 WILLOUGHBY CT"
        End If
        If AttributeName = "Address2" Then
            Return "ALGONQUIN IL 60102"
        End If

        ' Phone
        If AttributeName = "Phone1" Then
            Return "(847) 845-6410"
        End If

        ' Site Email
        If AttributeName = "SiteEmailContact" Then
            Return "none@none.com"
        End If

        ' Site Sales and Support
        If AttributeName = "SiteEmailSales" Then
            Return "none@none.com"
        End If
        If AttributeName = "SiteEmailSupport" Then
            Return "Mikish.Vaughn@Gmail.com"
        End If

        ' Facebook Page
        If AttributeName = "SiteFacebookPageURL" Then
            Return ""
        End If

        ' Google Maps Location
        If AttributeName = "SiteGoogleMapURL" Then
            Return "https://www.google.com/maps/place/8+Willoughby+Ct,+Algonquin,+IL+60102/@42.14977,-88.320628,16z/data=!4m5!3m4!1s0x880f0dfecc67645d:0x46cd813aa7f413!8m2!3d42.1497696!4d-88.3206282?hl=en-US"
        End If

        ' Site Images
        If AttributeName = "BigLogo" Then
            Return "/Content/Images/Site/Catagories/Svg/BlueSun.svg"
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

    ' ImageCount() 
    '********************
    '
    ' Returns the image count in a carousel image folder.
    '
    <AllowAnonymous>
    Public Shared Function ImageCount(Msg As String) As Integer

        Dim Count As Integer = 1
        Try
            If HttpContext.Current.Request.IsLocal Then
                Count = IO.Directory.GetFiles("D:\Projects\Repos\Daycare\Content\Images\Site\Carousel\" + Msg + "\", "*.jpg").Length()
            Else
                Count = IO.Directory.GetFiles("h:\root\home\mikish-001\www\Daycare\content\images\site\Carousel\" + Msg + "\", "*.jpg").Length()
            End If
        Catch ex As Exception
            MsgBox("Image Directory Not Found", MsgBoxStyle.Critical)
            Return Count
        End Try

        Return Count

    End Function

    ' GetImageLocation 
    '********************
    '
    <AllowAnonymous>
    Public Shared Function GetImageLocation() As String

        Dim ImageLocation As String = "/Content/Images/"
        If HttpContext.Current.Request.IsLocal Then
            ImageLocation = "/Content/Images/"
        End If

        Return ImageLocation

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