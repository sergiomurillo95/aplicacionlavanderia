using System.Collections.Generic;

namespace Dtos
{
    public class ListadoDetallesSolicitudDto
    {
        public List<DetalleSolicitudDto> DetalleSolicitud { get; set; } = new List<DetalleSolicitudDto>();
    }
}
