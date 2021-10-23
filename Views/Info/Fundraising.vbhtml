@Code
    ViewData("Title") = "Fundraising"
End Code

<h2 class="text-center">@ViewData("Title")</h2>
<div class="center">
    @Html.Partial("Cards/Fundraising/_Fundraising")
</div>