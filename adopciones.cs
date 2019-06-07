namespace Actividad
{
    class Adopciones
    {

        private string IdAdopciones;
        public Mascoat _mascotas;
	public Usuarios _usuarios;
        
        private string NombreMascota;
        private string Hora;
	private string Fecha;
        private string NombreDelCentro;

        public void Transaccion(Mascotas mascotas, Usuarios usuarios){
            this._usuarios = usuarios;
            this._mascotas =  mascotas;
        }
        
    }
}
