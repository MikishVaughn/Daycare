@Code

    ' Get Title and Site Name 
    ViewData("Title") = ViewData("Message")

    ' Get Site Info
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
    Dim siteDescription As String = SiteHelpers.GetSiteInfo("SiteDescription")

    ' Page Image(s)
    Dim pageImage_About As String = SiteHelpers.GetSiteInfo("PageImage_About")

End Code


<div class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div class="row gx-4 gx-lg-5 align-items-center my-5">

        <!-- Page Image -->
        <div class="col-lg-7">
            <img class="img-fluid rounded mb-4 mb-lg-0" src=@pageImage_About alt="Page Image" id="page-image" />
        </div>

        <!-- Brand Card -->
        @Html.Partial("Cards/_Brand")        

    </div>

    <!-- Call to Action Card -->
    @Html.Partial("Cards/_CallToAction")
    

    <!-- Content Row-->
    <div class="row gx-4 gx-lg-5">

        <!-- Card -->
        @Html.Partial("Cards/_Merchandise")

        <!-- Card -->
        @Html.Partial("Cards/_Schedule")

        <!-- Card -->
        @Html.Partial("Cards/_Other")

    </div>
</div>
