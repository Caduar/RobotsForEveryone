Robots For Everyone (R4E)
======


R4E es un plataforma de RPA open source, la cual busca democratizar el desarrollo e implementación de robots para cualquiera que se encuentre interesado en la automatización de procesos.
El proyecto está creado bajo la tecnología de Microsoft Workflow Foundations (WF), y está escrito en C#, el proyecto “encapsula” WF para crear un nuevo IDE (entorno de desarrollo integrado) personalizado, para ello se usa el proceso de “Rehosting the workflow Designer”.

https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/rehosting-the-workflow-designer


![alt text](https://github.com/Caduar/RobotsForEveryone/blob/master/ImgGuide/R4E%20MainWindow.PNG)

### Tecnologías utilizadas

El objetivo de este proyecto es utilizar este IDE para crear todo un entorno de automatización basado en actividades, las actividades son .dll que se pueden añadir al proyecto mediante la interfaz gráfica o por a través del código.
Para crear las actividades de automatización existen muchas ayudas, en lo personal para automatizaciones de escritorio utilizo FLAUI y para las automatizaciones web se espera utilizar selenium

* FlaUI: https://github.com/Roemer/FlaUI
* Selenium: https://www.seleniumhq.org/download/

Existen dos tipos de actividades, las actividades con diseño y las actividades normales, crear una actividad con diseño requiere mucho más tiempo y saber utilizar Windos Presentation Foundations (WPF). En el proyecto se encuentra una carpeta llamada “CustomActivitiesExamples \FirstCustomActivity”, este es ejemplo de cómo crear una actividad simple.
En la carpeta “CustomActivitiesExamples\LaunchProgram” se encuentra un ejemplo de cómo crear una actividad con diseño.

### ¿Cómo editar el IDE?
Para editar el IDE consulta nuestra wiki:
* Pendiente por actulizar.

### ¿Cómo crear una actividad personalizada?
Para crear actividades personalizadas consulta nuestra wiki:
* Pendiente por actulizar
* Por el momento dejo como crear una actvidad personalizada en UiPath en el siguiente video: https://www.youtube.com/watch?v=LkuSKKn4w1s

PD: para añadir la actividad y probar sin editar el código, solamente se da click en archivo, añadir referencia y escogemos el .dll que creamos, de forma inmediata lo veremos a un costado

![alt text](https://github.com/Caduar/RobotsForEveryone/blob/master/ImgGuide/A%C3%B1adir%20referencia.png)

![alt text](https://github.com/Caduar/RobotsForEveryone/blob/master/ImgGuide/Seleccionar%20referencia.PNG)

![alt text](https://github.com/Caduar/RobotsForEveryone/blob/master/ImgGuide/Referencia%20a%C3%B1adida.PNG)


Hecho con <img src="https://github.com/Caduar/RobotsForEveryone/blob/master/ImgGuide/Corazon.png" alt="IMAGE ALT TEXT HERE" width="20" height="20" /> en Colombia