@Code
    ViewData("Title") = "High School Schedule"
End Code

<h2 class="text-center">@ViewData("Title")</h2>
<div class="center">
    @Html.Partial("Cards/Schedule/_HighSchool")
</div>
