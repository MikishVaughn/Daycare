Public Class InfoController
    Inherits System.Web.Mvc.Controller
    Function About() As ActionResult
        ViewData("Message") = "About"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contact"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function TOS() As ActionResult
        ViewData("Message") = "TOS"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Privacy() As ActionResult
        ViewData("Message") = "Privacy"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Events() As ActionResult
        ViewData("Message") = "Events"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Schedule() As ActionResult
        ViewData("Message") = "Schedule"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
    Function Fundraising() As ActionResult
        ViewData("Message") = "Fundraising"
        ViewData("PageHeader") = ViewData("Message")
        ViewData("PageTitle") = ViewData("Message")
        Return View()
    End Function
End Class
