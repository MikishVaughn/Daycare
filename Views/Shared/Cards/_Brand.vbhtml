@code

    ' Get Image Info
    Dim BigLogo As String = SiteHelpers.GetSiteInfo("BigLogo")

    ' Get Site Info
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDescription As String = SiteHelpers.GetSiteInfo("SiteDescription")

End Code

<div class="col-lg-5">
    <div class="card h-100 noborder">
        <div class="card-body">

            <!-- No Title -->
            <h2 class="card-title"></h2>

            <!-- Show  Big Logo -->
            <img style="height:  160px; width: 360px;" src=@BigLogo class="img-fluid" alt="Responsive Big Logo" id="big-logo" />

            <!-- Site Name -->
            <h1 class="font-weight-light">@siteName</h1>

            <!-- Site Discription -->
            <p class="card-text">@siteDescription</p>

            <!-- Call to Action Button -->
            <a class="btn btn-primary" href="~/Info/Fundraising">Call to Action!</a>

        </div>
    </div>
</div>
