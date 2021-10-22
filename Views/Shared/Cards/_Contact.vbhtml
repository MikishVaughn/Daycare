@code

    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteGoogleMapURL As String = SiteHelpers.GetSiteInfo("SiteGoogleMapURL")
    Dim siteFacebookPageURL As String = SiteHelpers.GetSiteInfo("SiteFacebookPageURL")
    Dim siteContact As String = SiteHelpers.GetSiteInfo("SiteContact")
    Dim siteEmailContact As String = SiteHelpers.GetSiteInfo("SiteEmailContact")
    Dim address1 As String = SiteHelpers.GetSiteInfo("Address1")
    Dim address2 As String = SiteHelpers.GetSiteInfo("Address2")

    Dim siteDesigner As String = SiteHelpers.GetSiteInfo("SiteDesigner")
    Dim siteEmailDesigner As String = SiteHelpers.GetSiteInfo("SiteEmailDesigner")

    ' Page Images
    Dim designerLogo = SiteHelpers.GetSiteInfo("SiteDesignerLogo")
    Dim smallLogo = SiteHelpers.GetSiteInfo("SmallLogo")

End Code

<div class="text-center py-0">

    <!-- Please Contact us Text -->
    <div class="pt-4">
        <h3 class="font-weight-bold">Contact Us:</h3>
    </div>

    <!-- Contact Info box -->
    <Container>
        <div class="card mx-auto border-dark mb-3" style="max-width: 24rem;">
            <div class="card-header"><h6><img class="brandlogo" src=@smallLogo alt="brand logo">@siteName</h6></div>
            <div class="card-body text-dark">

                <h5 class="card-title text-start">@siteContact</h5>

                <div class="card-text text-start">
                    <div>@address1</div>
                    <div>@address2</div>
                    <div class="py-2">Email: <a class="text-black " href="mailto: @siteEmailContact">@siteEmailContact</a></div>
                </div>
                <div class="py-2">
                    <!-- Facebook Page Button -->
                    <div class="py-1">
                        <button style="width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteFacebookPageURL')">
                            <img style="height:32px; width:32px;" src="~/Content/Images/Site/Catagories/Svg/FB-Square.Svg" /> <b>Facebook Page</b>
                        </button>
                    </div>

                    <!-- Google Page Button -->
                    <div class="py-1">
                        <button style="width: 200px; border-radius:8px; padding-left: 20px;text-align: left;" onclick="newTab('@siteGoogleMapURL')">
                            <img style="height:32px; width:32px;" src="~/Content/Images/Site/Catagories/Svg/Google-Square.svg" /> &nbsp;&nbsp;&nbsp;&nbsp;<b>Google Maps</b>
                        </button>
                    </div>
                </div>
            </div>
        </div>            

        <!-- Website Designer Text -->
        <div class="pt-lg-5">
            <h4 class="font-weight-bold">Website Designer:</h4>
        </div>

        <!-- Designer Info -->
        <div class="card mx-auto border-dark mb-3" style="max-width: 24rem;">
            <div class="card-header"><h6><img class="brandlogo" src=@designerLogo alt="brand logo">@siteDesigner</h6></div>
            <div class="card-body text-dark">

                <h5 class="card-title text-start">Michael Vaughn</h5>

                <div class="card-text text-start">
                    <div></div>
                    <div></div>
                    <div class="py-2">Email: <a class="text-black " href="mailto: @siteEmailDesigner">@siteEmailDesigner</a></div>
                </div>

            </div>
        </div>
    </Container>
</div>