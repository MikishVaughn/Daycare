Public Class MerchandiseController
    Inherits System.Web.Mvc.Controller
    Function Store() As ActionResult
        ViewData("Message") = "Store"

        Return View()
    End Function


End Class
