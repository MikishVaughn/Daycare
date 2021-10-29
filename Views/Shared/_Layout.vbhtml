@code

    ' Get Site Info From SiteHelers class where it is stored.
    Dim siteURL As String = SiteHelpers.GetSiteInfo("SiteURL")
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDescription As String = SiteHelpers.GetSiteInfo("SiteDescription")
    Dim linkShareImage As String = SiteHelpers.GetSiteInfo("LinkShare")

    ' Set og Stuff
    Dim canonical As String = siteURL
    Dim ogTitle As String = siteName
    Dim ogType As String = "website"
    Dim ogURL As String = siteURL
    Dim ogImage As String = linkShareImage
    Dim ogSite_Name As String = siteName
    Dim ogDescription As String = siteDescription

    ' Link Share Setup
    Select Case ViewData("Message")

        ' Change Image and Discription as needed per page,
        ' or let them default to the site LinkShare.
        Case "About", "Contact", "Events", "Store"
            ogTitle = ViewData("Message") + " " + siteName
            ogDescription = ViewData("Message")
            ogImage = linkShareImage
            canonical = siteURL + "/Info/" + ViewData("Message")

        Case "Privacy Policy", "Terms of Service", "Contact"
            ogTitle = ViewData("Message") + " " + siteName
            ogDescription = ViewData("Message")
            ogImage = linkShareImage
            canonical = siteURL + "/Info/" + ViewData("Message")
    End Select

    ogURL = canonical
End Code

<!DOCTYPE html>
<html lang="en" itemscope itemtype="http://schema.org/WebPage">

<!-- Header -->
<head prefix="og: http://ogp.me/ns# fb: http://ogp.me/ns/fb#">

    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!-- Site Name -->
    <title>@siteName</title>

    <!-- FavIcon(s) (more than enough) -->
    <link rel="icon" type="image/x-icon" href="~/Content/Images/Site/Catagories/Icons/Daycare/favicon.ico" />
    <link rel="icon" type="image/png" sizes="16x16" href="/~/Content/Images/Site/Catagories/Icons/Daycare/favicon-16x16.png">
    <link rel="icon" type="image/png" sizes="32x32" href="/~/Content/Images/Site/Catagories/Icons/Daycare/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="192x192" href="~/Content/Images/Site/Catagories/Icons/Daycare/android-chrome-192x192.png">
    <link rel="icon" type="image/png" sizes="512x512" href="~/Content/Images/Site/Catagories/Icons/Daycare/android-chrome-512x512.png">
    <link rel="shortcut icon" type="image/jpeg" href="~/Content/Images/Site/Catagories/Icons/Daycare/android-chrome-192x192.png" />
    <link rel="apple-touch-icon" type="image/pgn" href="~/Content/Images/Site/Catagories/Icons/Daycare/android-chrome-192x192.png" />
    <link rel="apple-touch-icon" type="image/pgn" sizes="180x180" href="~/Content/Images/Site/Catagories/Icons/Daycare/apple-touch-icon.png">

    <!-- Link Share Setup -->
    <link rel="canonical" href="@canonical" />
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta name="description" content="@ogDescription" />
    <meta property="og:type" content="website" />
    <meta property="og:site_name" content="@ogSite_Name" />
    <meta property="og:url" content="@ogURL" />
    <meta property="og:image:url" content="@ogImage" />
    <meta property="og:image:type" content="image/jpeg" />
    <meta property="og:image:width" content="600" />
    <meta property="og:image:height" content="1200" />
    <meta property="og:title" content="@ogTitle" />
    <meta property="og:description" content="@ogDescription" />
    <meta property="og:locale" content="en_US" />
    <meta name="twitter:card" content="photo" />
    <meta name="twitter:site" content="@ogSite_Name" />
    <meta name="twitter:title" content="@ogTitle" />
    <meta name="twitter:image" content="@ogImage" />
    <meta name="twitter:image:width" content="600" />
    <meta name="twitter:image:height" content="600" />

    <!-- Jquery -->
    <script src="~/Scripts/jquery.min.js"></script>

    <!-- Bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <!-- Site Local Css and Scss -->
    <link href="~/Css/styles.css" rel="stylesheet" />
    <link href="~/Css/Custom.css" rel="stylesheet" />
    <link href="~/Css/sitestyles.css" rel="stylesheet" />

    <!-- Site Local Scripts -->
    <script src="~/Scripts/sitescripts.js"></script>

</head>

<body class="bg-dark @*bg-gradient bg-opacity-50*@">

    <!-- Site Beginning -->
    <div class="container body-content px-0">
        <container>

            <!-- Header NavBar -->
            @Html.Partial("_Header")

            <!-- Main Content renders Info/About -->
            @RenderBody()

        </container>
    </div>
    
    <!-- Footer Menu -->
    @Html.Partial("_Footer")

</body>
</html>



