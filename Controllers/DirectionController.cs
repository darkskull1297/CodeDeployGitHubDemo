using Microsoft.AspNetCore.Mvc;

namespace ApiLocation.UI.Controllers;

[ApiController]
[Route("/api/direccion/")]
public class DirectionController : ControllerBase
{
    [HttpGet]
    [Route("provincias")]
    public List<string> GetProvincia()
    {
        var provincias = new List<string>() { "ALAVA", "ALBACETE", "ALICANTE", "ALMERIA", "ASTURIAS", "AVILA", "BADAJOZ", "BARCELONA", "BURGOS", "CACERES", "CADIZ", "CANTABRIA", "CASTELLON", "CEUTA", "CIUDAD REAL", "CORDOBA", "CUENCA", "GERONA", "GRANADA", "GUADALAJARA", "GUIPUZCOA", "HUELVA", "HUESCA", "ISLAS BALEARES", "JAEN", "LA CORUÑA", "LA RIOJA", "LAS PALMAS", "LEON", "LLEIDA", "LUGO", "MADRID", "MALAGA", "MELILLA", "MURCIA", "NAVARRA", "ORENSE", "PALENCIA", "PONTEVEDRA", "SALAMANCA", "SANTA CRUZ DE TENERIFE", "SEGOVIA", "SEVILLA", "SORIA", "TARRAGONA", "TERUEL", "TOLEDO", "VALENCIA", "VALLADOLID", "VIZCAYA", "ZAMORA", "ZARAGOZA" };

        return provincias;
    }
    [HttpGet]
    [Route("provincia")]
    public string GetProvincia(string provincia)
    {
        return provincia;
    }

    [HttpGet]
    [Route("poblacion")]
    public List<string> GetPoblacion(string provincia, string poblacion)
    {
        var ListaString = new List<string>();
        ListaString.Add(provincia);
        ListaString.Add(poblacion);
        return ListaString;
    }

    [HttpGet]
    [Route("tipovia")]
    public List<string> GetTipoVia(string provincia, string poblacion)
    {
        var ListaString = new List<string>();
        ListaString.Add(provincia);
        ListaString.Add(poblacion);
        ListaString.Add("Calle");
        return ListaString;
    }

    [HttpGet]
    [Route("calle")]
    public List<string> GetCalle(string provincia, string poblacion, string tipovia, string calle)
    {
        var ListaString = new List<string>();
        ListaString.Add(provincia);
        ListaString.Add(poblacion);
        ListaString.Add(tipovia);
        ListaString.Add(calle);
        return ListaString;
    }

    [HttpGet]
    [Route("unidad")]
    public List<string> GetUnidad(string provincia, string poblacion, string tipovia, string calle, string numero)
    {
        var ListaString = new List<string>();
        ListaString.Add(provincia);
        ListaString.Add(poblacion);
        ListaString.Add(tipovia);
        ListaString.Add(calle);
        ListaString.Add(numero);
        ListaString.Add("1");
        return ListaString;
    }

}