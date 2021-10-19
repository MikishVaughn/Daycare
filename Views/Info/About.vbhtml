@Code
    ViewData("Title") = "About"
    Dim siteName As String = SiteHelpers.GetSiteInfo("SiteName")
End Code


<div class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div class="row gx-4 gx-lg-5 align-items-center my-5">
        <div class="col-lg-7">
            <img class="img-fluid rounded mb-4 mb-lg-0" src="~/Content/Images/Site/Misc/900x600-image-01.jpg" alt="Page Image" />
        </div>
        <div class="col-lg-5">
            <img style="height:  160px; width: 360px;" src="~/Content/Images/Site/Svg/BD-Body-01.svg" class="img-fluid" alt="Responsive Brand image" id="big-logo" />
            <h1 class="font-weight-light">Waterloo Bulldog Wrestling Club</h1>
            <p>This site is for all of our Support activities.</p>
            <a class="btn btn-primary" href="#!">Call to Action!</a>
        </div>
    </div>
    <!-- Call to Action-->
    <div class="card text-white bg-secondary my-5 py-4 text-center">
        <div class="card-body"><p class="text-white m-0">We are always looking for help and donations, Check out our schedule!</p></div>
    </div>
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
