using System;
using System.Collections.Generic;
using Collector.Models.Home;

namespace Collector.Services.Home
{
    public class MenuService
    {
        public List<BotoesMateriaisModel> ItensMenu()
        {

            return new List<BotoesMateriaisModel>
            {
                new BotoesMateriaisModel { Id=1, Imagem = "ic_papel.png", Texto="Papel" },
                new BotoesMateriaisModel { Id=2, Imagem = "ic_aluminio.png", Texto="Alumínio" },
                new BotoesMateriaisModel { Id=3, Imagem = "ic_plastico.png" , Texto="Plastico"},
                new BotoesMateriaisModel { Id=4, Imagem = "ic_oleo.png", Texto="Óleo" },
                new BotoesMateriaisModel { Id=5, Imagem = "ic_diversos.png", Texto="Diversos" },
                new BotoesMateriaisModel { Id=6, Imagem = "ic_metal.png" , Texto="Metal"},
                new BotoesMateriaisModel { Id=7, Imagem = "ic_podas.png", Texto="Podas de árvores" },
                new BotoesMateriaisModel { Id=8, Imagem = "ic_moveis.png", Texto="Moveis"},
                new BotoesMateriaisModel { Id=9, Imagem = "ic_eletronicos.png", Texto="Eletrônicos" },
                new BotoesMateriaisModel { Id=10, Imagem = "ic_entulho.png" , Texto="Entulho"},
                new BotoesMateriaisModel { Id=11, Imagem = "ic_vidro.png" , Texto="Vidro"},
                new BotoesMateriaisModel { Id=12, Imagem = "ic_bateria" , Texto="Bateria"},

            };

        }

    }
}
