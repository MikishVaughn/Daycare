@code
    Dim altText As String = ViewData("PageHeader")
    Dim folder As String = ViewData("Message")
    Dim imageLocation As String = SiteHelpers.GetImageLocation() + "site/Carousel/" + folder + "/"
    Dim imageCount As Integer = SiteHelpers.MaxImages(folder)
End Code

<!-- Input imageLink -->
<input type="text" spellcheck="false" value="" id="imageLink">

<!-- Carousel for Picture slides -->
<div id="CarouselControl" Class="carousel slide" data-ride="carousel" data-interval="false">

    <!-- The slideshow -->
    <div Class="carousel-inner" id="CarouselItems" style="color: white; width: 100%;"></div>

    <!-- Left And right controls -->
    <a class="carousel-control-prev" href="#CarouselControl" role="button" data-bs-slide="prev"></a>
    <a class="carousel-control-next" href="#CarouselControl" role="button" data-bs-slide="next"></a>   

</div>

<script>

    /* Create the Carousel Picture List */
    createImageList("@imageLocation", "@altText", @imageCount);

</script>

<script>

    $('#Previous').click(function (e) {
        e.stopPropagation();
        $('#CarouselControl').carousel('prev');
        return false;
    });

    $('#Next').click(function (e) {
        e.stopPropagation();
        $('#CarouselControl').carousel('next');
        return false;
    });

</script>