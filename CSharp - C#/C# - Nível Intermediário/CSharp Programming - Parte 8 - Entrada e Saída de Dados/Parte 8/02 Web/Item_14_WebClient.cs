﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Listings
{
    class Item_14_WebClient
    {
        static void XMain(string[] args)
        {
            //TAREFA:
            //Conectar-se site da caelum (http://www.caelum.com.br)
            //apenas para obter e exibir o conteúdo da página do site
            //mas de forma mais simples e rápida

            WebClient webClient = new WebClient();
            var textoDoSite = webClient.DownloadString("http://www.caelum.com.br");

            Console.WriteLine(textoDoSite);
            
            Console.ReadKey();
        }
    }
}
