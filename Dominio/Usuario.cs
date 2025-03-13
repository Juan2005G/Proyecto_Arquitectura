/// Entidad de la base de datos 
namespace Dominio
{
    /// <summary>
    /// Clase que contiene las caracteristicas del Usuario en la bd
    /// </summary>
    public class Usuario
    {

        /// <summary>
        /// Identificador Unico del usuario
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nombre del Usuario
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Correo electronico del Usuario
        /// </summary>
        public string Email { get; set; }
    }
}
