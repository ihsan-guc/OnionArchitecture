# OnionArchitecture




Onion Architecture is an architectural approach for software development. This approach aims for software to have a layered structure and for the layers to be isolated from each other. This makes software development, testing, and maintenance easier.
Domain, Application, Persistence, Infrastructure, and Presentation. These layers fulfill different responsibilities in the software and work with minimum dependency on each other.
<br>
<br> 

<p align="center">
  <img src="https://github.com/ihsan-guc/OnionArchitecture/blob/master/src/WebApi/OnionArchitecture.WebApi/Content/OnionArhitecture.png" width="350" alt="onion_architecture">
</p>
<br>

* Domain Layer: This layer is where the objects and business rules used in the software are defined. The domain layer is not dependent on other layers and can be independently tested.

* Application Layer: This layer is built on top of the domain layer and is where the application logic is implemented. This layer handles user requests and applies the business rules defined in the domain layer.

* Persistence Layer : This layer is responsible for storing data permanently. Database operations are performed in this layer.

* Infrastructure Layer : This layer is used to communicate with external systems (e.g. message queues, email servers).

* Presentation Layer: This layer is where the user interface (UI) is located. In this layer, user requests are handled and the results are shown to the user.

Onion Architecture ensures that the different layers of software work with minimum dependency on each other and enables easier development, testing, and maintenance of the software.
