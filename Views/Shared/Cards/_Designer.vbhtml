@code  

    Dim siteDesigner As String = SiteHelpers.GetSiteInfo("SiteDesigner")
    Dim siteEmailDesigner As String = SiteHelpers.GetSiteInfo("SiteEmailDesigner")

    ' Page Images
    Dim designerLogo = SiteHelpers.GetSiteInfo("SiteDesignerLogo")

End Code

<div class="text-center py-0">    

    <!-- Website Designer Card -->
    <div class="pt-lg-5 w-100 text-center">
        <h4 class="font-weight-bold">Website Designer:</h4>
    </div>

    <!-- Designer Info -->
    <div class="card mx-auto border-dark mb-3" style="max-width: 24rem;">
        <div class="card-header w-100 text-center"><h6><img class="brandlogo" src=@designerLogo alt="brand logo">@siteDesigner</h6></div>
        <div class="card-body text-dark">

            <h5 class="card-title text-start">Michael Vaughn</h5>

            <div class="card-text text-start">
                <div></div>
                <div></div>
                <div class="py-2">Email: <a class="text-black " href="mailto: @siteEmailDesigner">@siteEmailDesigner</a></div>
            </div>

        </div>
    </div>

</div>