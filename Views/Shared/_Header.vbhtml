﻿@code
    Dim choice01 As String = ""
    Dim choice02 As String = ""
    Dim choice03 As String = ""
    Dim choice04 As String = ""

    If ViewData("message") = "About" Then
        choice01 = "active"
    End If
    If ViewData("message") = "Events" Then
        choice02 = "active"
    End If
    If ViewData("message") = "Schedule" Then
        choice03 = "active"
    End If
    If ViewData("message") = "Merchandise" Then
        choice04 = "active"
    End If
End Code

<!-- NavBar -->
<div>
    <nav class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark border-bottom box-shadow mb-3 navbar navbar-light">
        <div class="d-flex flex-grow-1">
            <span class="w-100 d-lg-none d-block">
                <!-- hidden spacer to center brand on mobile -->
            </span>

            <!-- Title set to show on lg -->
            <a class="navbar-brand d-none d-lg-inline-block" href="~/Info/About"><img src="~/Content/Images/Site/Svg/BD-Head-Right-02.svg" alt="brand logo" id="brand-logo">Waterloo Bulldog Wrestling Club</a>

            <!-- Logo Image not shown on lg -->
            <a class="navbar-brand-two mx-auto d-lg-none d-inline-block" href="~/Info/About">
                <img src="~/Content/Images/Site/Svg/BD-Head-Right-02.svg" alt="brand logo" id="brand-logo">
            </a>

            <!-- Toggle Button -->
            <div class="w-100 text-left">
                <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarToggler" aria-controls="navbarToggler" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
            </div>

        </div>
        <div class="collapse navbar-collapse flex-grow-1 text-right" id="navbarToggler">
            <ul class="navbar-nav ms-auto flex-nowrap">
                <li class="nav-item text-light">
                    <a class="nav-link @choice01" aria-current="page" href="~/Info/About">About</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice02" href="~/Info/Events">Events</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice03" href="~/Info/Schedule">Schedule</a>
                </li>
                <li class="nav-item text-light">
                    <a class="nav-link @choice04" href="~/Merchandise/Store">Merchandise</a>
                </li>
            </ul>
        </div>
    </nav>    

</div>

