using System;
using System.Collections.Generic;
using Collector.Models.Home;

namespace Collector.Services.Home
{
    public class MenuService
    {
        public List<MateriaisModel> ItensMenu()
        {
            return new List<MateriaisModel>
            {
                new MateriaisModel { Id=1, Imagem="ic_papel.png", Texto="Papel", Titulo="100% reciclavel e biodegradavel", Descricao="  Reciclamos 1/3 do produzido 1 tonelada reciclada poupa 22 árvoes evite molhar, rasgar ou amassar não misture papel engordurado  lave embalagens longa vida no enxágue da louça." },
                new MateriaisModel { Id=2, Imagem="ic_aluminio.png", Texto="Alumínio", Titulo="Em 60 dias, 1 lata é produzida, comprada, coletada reciclada e volta as prateleiras", Descricao="    Reciclamos 98,4% das latinhas do Brasil, e apenass 33% dos outros itens de alumínio reciclar gastar 95% menos energia do que produzi-la" },
                new MateriaisModel { Id=3, Imagem="ic_plastico.png" , Texto="Plastico", Titulo="O Brasil só recicla 20% da produção  8 bilhões de kg/ano poluem os oceanos", Descricao="    Recicle sacolas, salgadinhos, sachês, canudos, isopor e todos os outros platicos limpe restosde alimentos com água do enxague da  louça ou guardanapo usado." },
                new MateriaisModel { Id=4, Imagem="ic_oleo.png", Texto="Óleo", Titulo="1L no ralo = 25 mil L de água poluída", Descricao="  Numca descarte na pia ou no vaso depois de usado e esfriado, o óleo deve ser coado numa garrafa PET com tampa peça ao catador para levar a um ponto de coleta ou cooperativa que produz sabão."  },
                new MateriaisModel { Id=5, Imagem="ic_diversos.png", Texto="Diversos", Titulo="É o pior metarial para os catadores, seu valor é muito baixo", Descricao="   O Brasil perde R$ 8 bilhões/ano enterrando reciclaveis misturados remédios e suas embalagens laminadas devem ser descartados nas farmácias."  },
                new MateriaisModel { Id=6, Imagem="ic_metal.png" , Texto="Metal", Titulo="Aço é o material mais reciclado do mundo, é 100% reciclável, infinitas vezes", Descricao="    1/4 do aço no Brasil utiliza matérial reciclada, metais reciclado estão em latas de alimentos, ferramentas, arames, vigas, automóveis e utensílios domésticos." },
                new MateriaisModel { Id=7, Imagem="ic_podas.png", Texto="Podas de árvores", Titulo="Podas de árvore podem ser compostadas e produzir energia", Descricao="   Em eventos e festas, organize a separação dos recicláveis secos em sacos grandes grandes avalie e combine com o catador a coleta dos residuos não listados neste aplicativo."},
                new MateriaisModel { Id=8, Imagem="ic_moveis.png", Texto="Moveis", Titulo="Cheque o tamanho da carroça", Descricao="    Combine com o catador o ponto de descarte dos móveis, garanta que o móvel não terminará em um terreno baldio ou na rua." },
                new MateriaisModel { Id=9, Imagem="ic_eletronicos.png", Texto="Eletrônicos", Titulo="98% dos componentes de um eletronico podem ser reciclados", Descricao="    Tem valor mais alto, mas so 15,5% é reciclado, falta infraestrutura no Brasil, são altamente contaminantes, busque a destinação correta."  },
                new MateriaisModel { Id=10, Imagem="ic_entulho.png" , Texto="Entulho", Titulo="Pode-se aproveita 95% do material e sua reciclagem é obrigatoria", Descricao="   Reutilizado em  ruas e estradas garanta que seu entulho não acabará em um terreno baldio cheque com sua prefeitura o local adequado." },
                new MateriaisModel { Id=11, Imagem="ic_vidro.png" , Texto="Vidro", Titulo="100% reciclável e dura para sempre preço baixo, poucos lugares reciclam", Descricao="    Vidro quebrado é ainda pior maior número de acidentes com catadores lâmpadas, TVs e espelhos prescisam de atenção especial. " },
                new MateriaisModel { Id=12, Imagem="ic_bateria" , Texto="Bateria", Titulo="São  altamente contaminantes", Descricao="   Estão nos celulares, telefones  sem fio, máquinas fotograficas, filmadoras, laptops, brinquedos e relógios, não podem ser misturadas separe e avise o catador antes da coleta." },
            };
        }
    }
}