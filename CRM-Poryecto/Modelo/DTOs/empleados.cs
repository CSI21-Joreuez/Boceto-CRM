namespace CRM_Poryecto.Modelo.DTOs
{
    public class empleados
    {
        int id;
        string passwd;
        string cod_empl;
        int nivel_acceso;

        public int Id { get => id; set => id = value; }
        public string Passwd { get => passwd; set => passwd = value; }
        public string Cod_empl { get => cod_empl; set => cod_empl = value; }
        public int Nivel_acceso { get => nivel_acceso; set => nivel_acceso = value; }

    }
}
