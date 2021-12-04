Feature: Probar las funcionalidades de curriculum



Scenario: Listar registros de Curriculum del usuario 1
    Given la siguiente solicitud
    """
    """
    When se solicita "sin" credenciales que se procese a la url "/api/curriculum/1/user", usando el metodo "get"
    Then la respuesta debe tener el codigo de estado 200 
    Then imprimir la respuesta


Scenario: Crear Curriculum
    Given la siguiente solicitud
    """
     {
      "name": "Juan",
      "lastName": "Perez",
      "cellphone": "1312312",
      "phone": "3331",
      "nationality": "Camba",
      "typeDocumentId": 2,
      "documentNumber": 1,
      "birthday": "2021-12-03T19:33:14.346Z",
      "genderId": 2,
      "maritalStatusId": 2,
      "clientId": 2
    }

    """
    When se solicita "sin" credenciales que se procese a la url "/api/curriculum", usando el metodo "post"
    Then la respuesta debe tener el codigo de estado 200  
    Then imprimir la respuesta
    

Scenario: Crear Curriculum Forma incorrecta
    Given la siguiente solicitud
    """
     {
      "name": "Juan",
      "lastName": "Pereza",
      "cellphone": "ASDASD",
      "phone": "SADSADDAS",
      "nationality": "Camba",
      "typeDocumentId": 2,
      "documentNumber": 1,
      "birthday": "2021-12-03T19:33:14.346Z",
      "genderId": 2,
      "maritalStatusId": 2,
      "clientId": 2
    }

    """
    When se solicita "sin" credenciales que se procese a la url "/api/curriculum", usando el metodo "post"
    Then la respuesta debe tener el codigo de estado 400
    And la respuesta debe contener un error validacion con estos campos definidos
    """
        "El formato del número de telefono es incorrecto"
    """
    

Scenario: Actualizar Curriculum
    Given la siguiente solicitud
    """
     {
      "name": "David",
      "lastName": "Chavez",
      "cellphone": "1312312",
      "phone": "3331",
      "nationality": "Camba",
      "typeDocumentId": 2,
      "documentNumber": 1,
      "birthday": "2021-12-03T19:33:14.346Z",
      "genderId": 2,
      "maritalStatusId": 2,
      "clientId": 2
    }

    """
    When se solicita "sin" credenciales que se procese a la url "/api/curriculum/curriculum/1", usando el metodo "put"
    Then la respuesta debe tener el codigo de estado 200 


Scenario: Eliminar Curriculum
    Given la siguiente solicitud
    """
    """
    When se solicita "sin" credenciales que se procese a la url "/api/curriculum/1/delete", usando el metodo "delete"
    Then la respuesta debe tener el codigo de estado 200 
