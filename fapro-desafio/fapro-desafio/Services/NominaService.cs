using fapro_desafio.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Xml.Linq;

namespace fapro_desafio.Services
{
    public class NominaService : INominaService
    {
        private readonly IWebDriver _driver;
        private List<NominaRegistro> _nominas;
        public NominaService()
        {
      this._driver  = new ChromeDriver();
            _nominas = new List<NominaRegistro>();
        }

        public List<NominaRegistro> GetNominaRegistros()
        {

        
            _driver.Navigate().GoToUrl("https://www.sii.cl/servicios_online/1047-nomina_inst_financieras-1714.html");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // find the form and fill it
            var trs = _driver.FindElements(By.TagName("tr"));
            var trs2 = _driver.FindElements(By.TagName("td"));
      
            foreach (var tr in trs)
            {
                var tds = tr.FindElements(By.TagName("td"));
                if (tds.Count > 0)
                {
                    _nominas.Add(new NominaRegistro
                    {
                        No = int.Parse(tds[0].Text)
                     ,
                        RazonSocial = tds[1].Text
                     ,
                        Pais = tds[2].Text
                     ,
                        DatosInscripcion = tds[3].Text
                     ,
                        Vigencia = tds[4].Text
                     ,
                        DatosUltimaActualizacion = tds[5].Text
                     ,
                        Estado = tds[6].Text
                    });


                }
            }
            _driver.Close();
            return _nominas;
        }

       
    }
}

