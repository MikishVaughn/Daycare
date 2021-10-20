<!-- Footer -->
<footer class="py-3">

    <div class="row">
        <div class="col-4">

            <h5>Info</h5>
            <ul class="nav flex-column">
                <li class="nav-item mb-2"><a href="~/Info/About" class="nav-link p-0 text-muted">About</a></li>
                <li class="nav-item mb-2"><a href="~/Info/Contact" class="nav-link p-0 text-muted">Contact</a></li>
            </ul>
        </div>

        <div class="col-4">
            <h5>Features</h5>
            <ul class="nav flex-column">
                <li class="nav-item mb-2"><a href="~/Merchandise/Store" class="nav-link p-0 text-muted">Merchandise</a></li>
                <li class="nav-item mb-2"><a href="~/Info/Schedule" class="nav-link p-0 text-muted">Schedule of Events</a></li>
                <li class="nav-item mb-2"><a href="~/Info/Fundraising" class="nav-link p-0 text-muted">Fundraising</a></li>
            </ul>
        </div>

        <div class="col-4">
            <h5>Policies</h5>
            <ul class="nav flex-column">
                <li class="nav-item mb-2"><a href="~/Info/TOS" class="nav-link p-0 text-muted">Terms of Service</a></li>
                <li class="nav-item mb-2"><a href="~/Info/Privacy" class="nav-link p-0 text-muted">Privacy Policy</a></li>
            </ul>
        </div>

    </div>

    <!-- Timezone --> 
    <div class="card my-4 py-3 text-center noborder">
        <div id="timezone"></div>
    </div>

</footer>

<script>
    var timezonestring = Intl.DateTimeFormat().resolvedOptions().timeZone + " " + new Date().toTimeString().slice(9);
    try {
        document.getElementById("timezone").innerHTML = timezonestring;

    } catch (e) {
        // Do nothing. id probably doesn't exist.
    }
</script>