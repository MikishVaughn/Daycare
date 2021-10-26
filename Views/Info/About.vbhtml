@Code
    ' Get Title and Site Name
    ViewData("Title") = ViewData("Message")
End Code        

<div Class="container px-4 px-lg-5">

    <!-- Heading Row-->
    <div Class="row gx-4 gx-lg-5 align-items-end my-3">

        <!-- Brand Card -->
        @Html.Partial("Cards/About/_Brand")

        <!-- Page Image Carousel -->
        @Html.Partial("_Carousel")

        <!-- Show Single Image -->
        @*<div class="col-lg-7">
            <img class="img-fluid rounded mb-4 mb-lg-0 p-0" src=@pageImage_About alt="Page Image" id="page-image" />
        </div>*@

    </div>

    <!-- Content Row-->
    <div class="row gx-1 gx-lg-5">

        <!-- Schedule Card -->
        @Html.Partial("Cards/About/_Schedule")

        <!-- Fundraising Card -->
        @Html.Partial("Cards/About/_Fundraising")

        <!-- Merchandise Card -->
        @Html.Partial("Cards/About/_Merchandise")

    </div>
</div>
