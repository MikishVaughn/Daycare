@code

    ' Get Image Info
    Dim BigLogo As String = SiteHelpers.GetSiteInfo("BigLogo")

    ' Get Site Info
    Dim siteName1 As String = "The Daycare Center"
    Dim siteName2 As String = ""
    Dim siteDescription As String = SiteHelpers.GetSiteInfo("SiteDescription")

End Code

<div class="col-lg-5">
    <div class="card h-100 bg-dark noborder">
        <div class="card-body text-center">
            
            <!-- Show  Big Logo -->
            <img style="height:  203px; width: 360px;" src=@BigLogo class="img-fluid" alt="Responsive Big Logo" id="big-logo" />

            <!-- Site Name -->
            <h2 class="font-weight-light sitename">@siteName1</h2>
            <h2 class="font-weight-light sitename">@siteName2</h2>

            <!-- Site Discription -->
            @*<p class="card-text">@siteDescription</p>*@

            <!-- Call to Action Button -->
            @*<a class="btn btn-primary" href="~/Info/Fundraising">Call to Action!</a>*@

        </div>
    </div>

    <!-- Call to Action Card -->
    @Html.Partial("Cards/About/_Description")

</div>
