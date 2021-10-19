Public Class InfoController
    Inherits System.Web.Mvc.Controller
    Function About() As ActionResult
        ViewData("Message") = "About"

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Contact"

        Return View()
    End Function
    Function TOS() As ActionResult
        ViewData("Message") = "TOS"

        Return View()
    End Function
    Function Privacy() As ActionResult
        ViewData("Message") = "Privacy"

        Return View()
    End Function
    Function Events() As ActionResult
        ViewData("Message") = "Events"

        Return View()
    End Function
    Function Schedule() As ActionResult
        ViewData("Message") = "Schedule"

        Return View()
    End Function
End Class
