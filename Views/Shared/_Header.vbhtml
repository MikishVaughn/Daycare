@code

    ' Keep Current Menu Selection Active (Highlighted)
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""
    Dim choice05 As String = ""

    If ViewData("message") = "About" Then
        choice01 = "active"
    End If
    If ViewData("message") = "Contact" Then
        choice02 = "active"
    End If
    If ViewData("message") = "Schedule" Then
        choice03 = "active"
    End If
    If ViewData("message") = "Fundraising" Then
        choice04 = "active"
    End If
    If ViewData("message") = "Merchandise" Then
        choice05 = "active"
    End If

    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteNameShort As String = SiteHelpers.GetSiteInfo("SiteNameShort")
    ' Page Images
    Dim smallLogo = SiteHelpers.GetSiteInfo("SmallLogo")

End Code

<!-- NavBar -->
<div>
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark border-bottom box-shadow mb-3 navbar navbar-light px-2 ">
        <div class="d-flex flex-grow-1">

            <!-- Hidden Space -->
            <span class="w-100 d-lg-none d-block">
                <!-- hidden spacer to center brand on mobile -->
            </span>

            <!-- Set to show on lg -->
            <a class="navbar-brand d-none d-lg-inline-block" href="~/Info/About"><img class="brandlogo" src=@smallLogo alt="brand logo">@siteName</a>

            <!-- Set to show on sm -->
            <a class="navbar-brand d-lg-none d-inline-block w-100" href="~/Info/About">@siteNameShort<img class="brandlogo2" src=@smallLogo alt="brand logo"></a>

        <!-- Toggle Button -->
        <div class="w-0 text-left ">
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarToggler" aria-controls="navbarToggler" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </div>
        </div>

        <!-- Selection Choices -->
        <div class="collapse navbar-collapse flex-grow-1 text-right" id="navbarToggler">
            <ul class="navbar-nav ms-auto flex-nowrap">
                <li class="nav-item text-light">
                    <a class="nav-link @choice01" aria-current="page" href="~/Info/About">About</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice02" href="~/Info/Contact">Contact Us</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice03" href="~/Info/Schedule">Schedule</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice04" href="~/Info/fundraising">Fundraising</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice05" href="~/Merchandise/Store">Merchandise</a>
                </li>
            </ul>
        </div>

    </nav>
</div>

