Robots For Everyone (R4E)
======


R4E es un plataforma de RPA open source, el cual busca democratizar el desarrollo e implementación de robots para cualquiera que se encuentre interesado en la automatización de procesos.
El proyecto está creado bajo la tecnología de Microsoft Workflow Foundations (WF), y está escrito en C#, el proyecto “encapsula” WF para crear un nuevo IDE (entorno de desarrollo integrado) personalizado, para ello se usa el proceso de “Rehosting the workflow Designer”.

https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/rehosting-the-workflow-designer


![alt text](https://github.com/Caduar/RobotsForEveryone/blob/master/ImgGuide/R4E%20MainWindow.PNG)

El objetivo de este proyecto es utilizar este IDE para crear todo un entorno de automatización basado en actividades, las actividades son .dll que se pueden añadir al proyecto mediante la interfaz gráfica o por a través del código.
Para crear las actividades de automatización existen muchas ayudas, en lo personal para automatizaciones de escritorio utilizo FLAUI y para las automatizaciones web se espera utilizar selenium

* FlaUI: https://github.com/Roemer/FlaUI
* Selenium: https://www.seleniumhq.org/download/

Existen dos tipos de actividades, las actividades con diseño y las actividades normales, crear una actividad con diseño requiere mucho más tiempo y saber utilizar Windos Presentation Foundations (WPF). En el proyecto se encuentra una carpeta llamada “CustomActivitiesExamples \FirstCustomActivity”, este es ejemplo de cómo crear una actividad simple.
En la carpeta “CustomActivitiesExamples\LaunchProgram” se encuentra un ejemplo de cómo crear una actividad con diseño.

Para editar el IDE consulta nuestra wiki:
* Pendiente por actulizar
Para crear actividades personalizadas consulta nuestra wiki:
* Pendiente por actulizar