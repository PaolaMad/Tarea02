using Tarea02.Models;

namespace Tarea02.Services
{
    public class RepositorioNews : IRepositorioNews
    {

        public IList<New> GetNews()
        {

            return new List<New> {

                new New {

                    Tittle = "Messi al Inter de Miami",
                    Category = "Deportes",
                    Description = "Leo Messi por fin llega a Estados Unidos para " +
                    "firmar su contrato y ser presentado por el Inter Miami, su nuevo equipo " +
                    "luego de dejar el PSG de la Ligue 1 de Francia.",
                    Author = "REDACCIÓN DIEZ",
                    Email = "diez@hn.com",
                    ImageURL = "/images/messi.jpg",
                    Date = DateTime.Now

                },

                new New
                {

                    Tittle = "BARBIEHEIMER",
                    Category = "Entretenimiento",
                    Description = "Los medios de comunicación siguen hablando sobre" +
                    "el mutuo estreno de las peliculas 'Barbie' y 'Oppenheimer'",
                    Author = "METROCINEMA",
                    Email = "metrocinema@gmail.com",
                    ImageURL = "/images/barbieheimer.jpg",
                    Date = DateTime.Now

                },

                new New
                {

                    Tittle = "Euro baja su valor",
                    Category = "Economía",
                    Description = "El euro ha tenido una de sus mayores caidas de su precio." +
                    "Llegando a estar cerca del mismo valor del dolar",
                    Author = "La Prensa",
                    Email = "laprensahn@gmail.com",
                    ImageURL = "/images/euro.jpg",
                    Date = DateTime.Now

                },

                new New
                {
                    Tittle = "Salvador Nasralla: “Rixi Moncada y Mel Zelaya " +
                    "quieren el dinero de la CAF para fines proselitistas y pagar deudas",
                    Category = "Política",
                    Description = "El designado presidencial, Salvador Nasralla, se pronunció" +
                    " este jueves acerca del envío al Poder Ejecutivo del decreto de adhesión de" +
                    " Honduras a la Corporación Andina de Fomento (CAF) pese a que se rechazara la " +
                    "ratificación del acta en el Congreso Nacional",
                    Author = "El Heraldo",
                    Email = "elheraldo@hn.com",
                    ImageURL = "/images/Politica.jpg",
                    Date = DateTime.Now
                },

                new New
                {

                    Tittle = "El tribunal de La Haya da la razón a Colombia frente a Nicaragua: " +
                    "3 claves de la disputa territorial entre ambos países en el mar de San Andrés",
                    Category = "Internacionales",
                    Description = "La Corte Internacional de Justicia de La Haya (CIJ) falló este " +
                    "jueves a favor de Colombia en la última de las disputas legales de ese país contra " +
                    "Nicaragua por el espacio marítimo que rodea a las islas de San Andrés y Providencia.",
                    Author = "NEWS Mundo",
                    Email = "newsmundo@gmail.com",
                    ImageURL = "/images/internacionales.jpg",
                    Date = DateTime.Now

                },

                new New
                {

                    Tittle = "FDA aprueba nuevo medicamento contra Alzheimer: contraindicaciones y quiénes lo pueden tomar",
                    Category = "Salud y Bienestar",
                    Description = "Tras ser aprobado un nuevo medicamento monoclonal para el tratamiento del Alzheimer, el Dr. " +
                    "Alejandro Andersson, neurólogo y director médico del Instituto de Neurología de Buenos Aires (INBA), cuenta " +
                    "en CNN Primera Mañana, qué pacientes pueden tomar el medicamento y qué efectos adversos tiene el mismo.",
                    Author = "CNNE",
                    Email = "cnne@gmail.com",
                    ImageURL = "/images/saludBienestar.jpeg",
                    Date = DateTime.Now

                },

            };

        }

    }
}
