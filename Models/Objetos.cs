using System.ComponentModel.DataAnnotations;

namespace Tar_5.Models
{
    public class Videojuego
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string Nombre { get; set; } = "";

        [Required(ErrorMessage = "El desarrollador es obligatorio")]
        [StringLength(100, ErrorMessage = "El desarrollador no puede tener más de 100 caracteres")]
        public string Desarrollador { get; set; } = "";

        [Required(ErrorMessage = "Debe seleccionar una plataforma")]
        public int PlataformaId { get; set; }

        public Plataforma? Plataforma { get; set; }

        [Required(ErrorMessage = "El género es obligatorio")]
        [StringLength(50, ErrorMessage = "El género no puede tener más de 50 caracteres")]
        public string Genero { get; set; } = "";

        [Required(ErrorMessage = "La fecha de lanzamiento es obligatoria")]
        public DateTime FechaLanzamiento { get; set; }

        [Url(ErrorMessage = "Debe proporcionar una URL válida para la imagen de portada")]
        public string ImagenPortada { get; set; } = "";

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [StringLength(1000, ErrorMessage = "La descripción no puede tener más de 1000 caracteres")]
        public string Descripcion { get; set; } = "";

        public List<Personaje>? Personajes { get; set; }
    }

    public class Plataforma
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; } = "";

        public bool Activa { get; set; }

        public List<Videojuego>? Videojuegos { get; set; }
    }

    public class Personaje
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string Nombre { get; set; } = "";

        [StringLength(50, ErrorMessage = "El alias no puede tener más de 50 caracteres")]
        public string Alias { get; set; } = "";

        [Required(ErrorMessage = "El rol en el juego es obligatorio")]
        [StringLength(50, ErrorMessage = "El rol no puede tener más de 50 caracteres")]
        public string RolEnJuego { get; set; } = "";

        [StringLength(100, ErrorMessage = "La habilidad especial no puede tener más de 100 caracteres")]
        public string HabilidadEspecial { get; set; } = "";

        [StringLength(50, ErrorMessage = "El arma favorita no puede tener más de 50 caracteres")]
        public string ArmaFavorita { get; set; } = "";

        [Range(1, 100, ErrorMessage = "El nivel de poder debe estar entre 1 y 100")]
        public int NivelPoder { get; set; }

        [Url(ErrorMessage = "Debe proporcionar una URL válida para la imagen del personaje")]
        public string ImagenPersonaje { get; set; } = "";

        [Required(ErrorMessage = "Debe seleccionar un videojuego")]
        public int VideojuegoId { get; set; }

        public Videojuego? Videojuego { get; set; }
    }
}