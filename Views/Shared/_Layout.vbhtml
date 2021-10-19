@code
    ' Page background
    Dim backgroundColor As String = "#FFFFFF"
    Dim backgroundImage As String = SiteHelpers.GetImageLocation() + "Categories/Backgrounds/main-bg.jpg"

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
            backgroundColor = "#000000"
            ogImage = linkShareImage
            canonical = siteURL + "/Info/" + ViewData("Message")

        Case "Privacy Policy", "Terms of Service", "Contact"
            ogTitle = ViewData("Message") + " " + siteName
            ogDescription = ViewData("Message")
            backgroundColor = "#000000"
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

    <!-- FavIcon -->
    <link rel="icon" href="/favicon.ico" type="image/x-icon" />
    <link rel="icon" type="image/png" sizes="32x32" href="/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="/favicon-16x16.png">
    <link rel="apple-touch-icon" sizes="180x180" href="/apple-touch-icon.png">
    <link rel="manifest" href="/site.webmanifest">

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

    <!-- Bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <!-- Site Local css -->
    <link href="~/Content/css/styles.css" rel="stylesheet" />
    <link href="~/Content/css/custom.css" rel="stylesheet" />
    <link href="~/Content/css/sitestyles.css" rel="stylesheet" />

    <!-- Site Local Scripts -->
    <script src="~/Scripts/sitescripts.js"></script>

</head>

<body>

    <!-- Site Beginning -->
    <div class="container body-content">
        <container>

            <!-- Header NavBar -->
            @Html.Partial("_Header")

            <!-- Main Content renders Info/About -->
            @RenderBody()
            <hr />

            <!-- Footer Menu -->
            @Html.Partial("_Footer")

        </container>
    </div>
</body>
</html>



