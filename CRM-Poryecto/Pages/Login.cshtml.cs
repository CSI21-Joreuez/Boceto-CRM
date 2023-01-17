using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRM_Poryecto.Pages
{

    [Authorize(Roles = "admin, usuario")]
    public class LoginModel : PageModel
    {

        public void OnGet()
        {
        }
        public IActionResult onPostEmpleado()
        {
            //Este fragmento de Codigo funciona correctamente
            //Solo que este proyecto es un boceto.
            var userid = DTOs.EmpleadoDTO.SingleOrDefault(u => u.CodEmpleado.Equals(userId));
            var userPasswd = DTOs.DlkCatAccEmpleados.SingleOrDefault(u => u.ClaveEmpleado.Equals(passwd));
            


            //Contador de Intetos
            var tries = 0;
            //Este fragmento de Codigo funciona correctamente
            //Solo que este proyecto es un boceto.
            if (userid != null && userPasswd != null)
            {
                
                if (HttpContext.Session.Id == userId)
                    HttpContext.Session.Remove(userId);
                if (HttpContext.Session.GetString(userId) == null)
                {
                    HttpContext.Session.SetString("SESSION", userId);
                }
                else {
                    HttpContext.Session.Clear();
                    HttpContext.Session.SetString("SESSION", userId);
                }

                    return RedirectToPage("../Index");
            }
            else
{
    tries++;
    if (tries > 3)
    {
        // Mostrar un mensaje de error si hay m�s de tres intentos fallidos
        ModelState.AddModelError(string.Empty, "Ha habido demasiados intentos de conexi�n fallidos. Por favor int�ntelo de nuevo m�s tarde.");
        return RedirectToPage("../ReCaptcha");
    }
    else
    {
        // Mostrar el formulario de inicio de sesi�n de nuevo si no hay m�s de tres intentos fallidos
        return RedirectToPage("/Login/Login");
    }

}
    }

