Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' As informações gerais sobre um assembly são controladas por
' conjunto de atributos. Altere estes valores de atributo para modificar as informações
' associada a um assembly.

' Revise os valores dos atributos do assembly

<Assembly: AssemblyTitle("Robotonomouz 205 2.0")>
<Assembly: AssemblyDescription("Nas últimas décadas, veículos autônomos têm motivado pesquisas em diversas áreas afins da computação, tais como inteligência artificial, algoritmos e robótica. A tarefa de construir um carro completamente independente de um condutor é extremamente complexa. Entretanto, testes avançados com os carros autônomos como os da Google, do Uber e da Tesla dão fortes indícios de que as pesquisas estão no caminho certo e que a corrida pelo lançamento de um carro completamente autônomo está próxima de um desfecho. Em geral, os carros autônomos captam diversas informações do ambiente por meio de sensores (infra-vermelho, lasers, câmeras de vídeo, entre outros) e, em seguida, as melhores decisões de movimentação são tomadas após o processamento dessas informações. O Arduino é uma plataforma eletrônica de código aberto baseada em hardware e software com interface de fácil interação que, por esse motivo, é bastante utilizada na iniciação de pesquisas em robótica. Ao longo dos anos, o Arduino tem sido o cérebro de diversos projetos que envolvem computação pervasiva, desde objetos simples do cotidiano até instrumentos científicos complexos, tais como drones e carros autônomos. Este projeto consiste em produzir um protótipo de um robô baseado em veículos autônomo que também seja controlado por conexão Bluetooth utilizando a plataforma Arduino. O robô-carro será monitorado e rastreado em tempo real por um monitor de eventos, e deverá conseguir se locomover por uma rota predefinida sem colidir com obstáculos posicionados ao longo desta rota, baseando-se em informações coletadas por meio de um sensor de distância. Este projeto, que envolve conhecimentos de eletrônica, programação e automação, é baseado no ACTP (Arduino Car Training Project) e foi implementado usando várias componentes da plataforma Arduino [1], tais como a Placa UNO R3, Micro Servo, Motor Shield, Mini Protoboard, Sensor de distância, Kit Chassi, Speaker, Chip de Bateria, Jumpers e Receptor Bluetooth. O monitor de eventos foi desenvolvido em linguagem Visual Basic.NET e o código está disponível em [2]. Dentre os resultados alcançados pelo projeto estão a iniciação na robótica usando Arduino e a produção de um protótipo funcional de robô-carro autônomo que possa ser usado para entreter a comunidade e também difundir a plataforma do Arduino. Finalmente, o conhecimento adquirido nesse projeto é fundamental para o desenvolvimento de novos projetos mais complexos, tais como a inserção de inteligência artificial e computacional no protótipo do robô-carro, e também outros projetos que envolvam veículos aéreos não tripulados (drones). Alison Israel Ferreira Paula (IFRJ, TI205), Felipe Davi de Souza Oliveira (IFRJ, TI205), Kaique dos Santos Nunes (IFRJ, TI205), Luan Felipe Santos Alves (IFRJ, TI205), Rodrigo Ferreira Nazareth (IFRJ, TI205), Tiago Vieira Nazareth de Souza (IFRJ, TI205), Vítor Hugo Silva Rangel (IFRJ, TI205), Orientador: Marcos Antonio Guerine Ribeiro")>
<Assembly: AssemblyCompany("Instituto Federal de Educação, Ciência e Tecnologia do Rio de Janeiro - Campus Pinheiral")>
<Assembly: AssemblyProduct("Robotonomouz 205 2.0")>
<Assembly: AssemblyCopyright("Copyright ©  2018")>
<Assembly: AssemblyTrademark("IFRJ - Campus Pinheiral")>

<Assembly: ComVisible(False)>

'O GUID a seguir será destinado à ID de typelib se este projeto for exposto para COM
<Assembly: Guid("9b895db8-7e98-4e60-814b-14facc6b8d50")>

' As informações da versão de um assembly consistem nos quatro valores a seguir:
'
'      Versão Principal
'      Versão Secundária 
'      Número da Versão
'      Revisão
'
' É possível especificar todos os valores ou usar como padrão os Números de Build e da Revisão
' utilizando o "*" como mostrado abaixo:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("2.1.0.3")>
<Assembly: AssemblyFileVersion("2.1.0.3")>
