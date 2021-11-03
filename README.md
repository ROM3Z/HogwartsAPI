# HogwartsAPI


Se implementan dos puntos finales GET

GET / https://localhost:44366/api/Aspirantes        
GET / https://localhost:44366/api/Aspirantes/{id}

Pruebe la aplicación llamando a los dos puntos finales desde un navegador o Postman. Por ejemplo:
 
 https://localhost:44366/api/Aspirantes    
 https://localhost:44366/api/Aspirantes/{id}

La llamada a Get: produce una respuesta similar a la siguiente :

[
    {
        "id": 1015,    
        "nombre": "Harry",    
        "apellido": "Potter",    
        "identificacion": 23,    
        "edad": 41,    
        "idCasa": "Gryffindor"   
    },   
    {
        "id": 1016,   
        "nombre": "Ronald",   
        "apellido": "Weasley",   
        "identificacion": 21,   
        "edad": 41,   
        "idCasa": "Gryffindor"   
    }
]

Utilice POST en Postman para Registrar un Aspirante:   
POST / https://localhost:44366/api/Aspirantes

{
"Nombre": "Ronald",
"Apellido":"Weasley",
"Identificacion": 21,
"Edad":41,
"IdCasa":"Gryffindor"
}

Utilice PUT  en Postman para Actualizar un Aspirante:    
PUT  / https://localhost:44366/api/Aspirantes/{id}

{
        "id": 1015,
        "nombre": "Harry",
        "apellido": "Potter",
        "identificacion": 23,
        "edad": 41,
        "idCasa": "Gryffindor"
    }
    
Utilice DELETE en Postman para eliminar un Aspirante:    
DELETE / https://localhost:44366/api/Aspirantes/{id}

{
        "id": 1015,
        "nombre": "Harry",
        "apellido": "Potter",
        "identificacion": 23,
        "edad": 41,
        "idCasa": "Gryffindor"
    }
    
