@code
    'Dim myLink1 As String = "https://docs.google.com/spreadsheets/d/e/2PACX-1vS_FHJRKx7Vc7gDNGCtn0KsIDN0Y9nzbrKRAmG_cSIlAjRDhzzTX_9EuSdxDj3nI3c6NBM6v0n3i-zf/pubhtml?widget=true&amp;headers=false"
    Dim myLink2 As String = "https://calendar.google.com/calendar/embed?src=vhgk8j1nj4n69nfl7leoiq8020%40group.calendar.google.com&ctz=America%2FChicago"
End Code 

<container>    
    <h2 class="text-center">The Daycare Center</h2>
    <h3 class="py-3 text-center">Contact: Heidi McCullough</h3>
    <p class="text-center">
        @*<a href="@myLink1" target="_blank" type="link" rel="noopener noreferrer nofollow">
            <span style="color:unset">Schedule Sheet with Results</span>
        </a>*@
    </p>
    <iframe class="container-fluid px-0" src="@myLink2" style="border: solid 1px #777; max-width: 800px" height="910" frameborder="0" scrolling="yes"></iframe>
</container>