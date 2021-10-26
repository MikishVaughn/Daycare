@code
    Dim copyright As String = "Copyright © " + Date.Now.Year.ToString + " by " + SiteHelpers.GetSiteInfo("SiteName")
    Dim siteName = SiteHelpers.GetSiteInfo("SiteName")

End Code
<footer id="site-footer" class="site-footer pt-2" role="contentinfo" aria-label="Site footer">
    <div class="site-footer__content" data-metrics-category="Global Footer" data-metrics-label="Footer">
        <div class="site-footer__module-group">

            <div class="site-footer__module  ps-2">
                <h6 class="site-footer__header">Info</h6>
                <ul>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/About">About Us</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/Contact">Contact Us</a></li>
                </ul>
            </div>

            <div class="site-footer__module">
                <h6 class="site-footer__header">Features</h6>
                <ul>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/Schedule">Schedule</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/Merchandise/Store">Merchandise</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/Fundraising">Fundraising</a></li>
                </ul>
            </div>

            <div class="site-footer__module">
                <h6 class="site-footer__header">Policies</h6>
                <ul>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/Privacy">Privacy Policy</a></li>
                    <li class="site-footer__item"><a class="nav-link" href="~/Info/TOS">Terms of Service</a></li>
                </ul>
            </div>

        </div>

        <div style="color: #f2f2f2; background-color: #60605F; margin: 0; padding: 0; width: 100%;">
            <h6 style="font-size: 10px; text-align: center; margin: 0; padding: 5px 10px 12px 5px; color: white; text-shadow: 0px 0px 2px black;">@siteName &copy; @DateTime.Now.Year All Rights Reserved.</h6>
        </div>

    </div>
</footer>

