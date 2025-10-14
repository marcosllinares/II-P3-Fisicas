# Interfaces Inteligentes - Práctica 3 - Físicas

**Autor:** Marcos Llinares Montes (alu0100972443)

## Ejercicio Físicas 3D
### Situación 1
El plano no es un objeto físico. El cubo es un objeto físico y la esfera no. En este caso, el plano y la esfera sólo tendrán collider, mientras que el cubo debe tener Rigidbody. 

![](https://i.imgur.com/J6ftuo5.png)

**Resultado:**
- El plano actúa como una superficie inmóvil
- La esfera, sin rigidbody, no se ve afectada por la gravedad y se mantiene flotando en suspensión
- El cubo, con rigidbody, se ve afectado por la gravedad, se queda apoyado en el plano

### Situación 2
El plano no es un objeto físico. El cubo es un objeto físico y la esfera también. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody. 

![a](https://imgur.com/6iNk7b6.gif)

**Resultado:**
- El plano actúa como una superficie inmóvil
- La esfera, con rigidbody, colisiona con el cubo y por la posición que tiene cae en la esquina, después cae plano y rueda por este 
- El cubo, con rigidbody, apoyado queda inmovil apoyado en el plano

### Situación 3
El plano no es un objeto físico. El cubo es un objeto físico y la esfera es cinemática. En este caso, el plano sólo tendrán collider, mientras que el cubo y la esfera deben tener Rigidbody esta última cinemático. 

![](https://i.imgur.com/U72pIRj.png)

**Resultado:**
- El plano actúa como una superficie inmóvil
- La esfera, con rigidbody y cinemático, queda inmóvil suspendida en el aire
- El cubo, con rigidbody, apoyado queda inmovil apoyado en el plano
La esfera al ser cinemático hace que desactive que la física no afecte al rigidbody. El movimiento de este objeto pasa a ser controlado por transform.
### Situación 4
El plano es un objeto físico. El cubo es un objeto físico y la esfera es física. En este caso, todos los objetos deben tener Rigidbody. 

![a](https://imgur.com/MO1Jnkq.gif)

**Resultado:**
- El plano, con rigidbody, cae por la gravedad
- La esfera, con rigidbody, cae por la gravedad
- El cubo, con rigidbody, cae por la gravedad
### Situación 5
El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 10 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.

![](https://i.imgur.com/48v63Tl.png)

![a](https://imgur.com/MO1Jnkq.gif)

**Resultado:**
- El plano, con rigidbody, desciende por la gravedad
- La esfera, con rigidbody, desciende por la gravedad
- El cubo, con rigidbody,desciende por la gravedad
La masa aumentada no afecta a la velocidad que desciende la esfera

### Situación 6
El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con 100 veces más masa que el cubo. En este caso, todos los objetos deben tener Rigidbody.

![](https://i.imgur.com/IR9OF08.png)

![a](https://imgur.com/MO1Jnkq.gif)


**Resultado:**
- El plano, con rigidbody, desciende por la gravedad
- La esfera, con rigidbody, desciende por la gravedad
- El cubo, con rigidbody,desciende por la gravedad
La masa por mucho que sea aumentada x100 no afecta a la velocidad que desciende la esfera
### Situación 7
El plano es un objeto físico. El cubo es un objeto físico y la esfera es física con fricción. En este caso, todos los objetos deben tener Rigidbody.

![](https://i.imgur.com/cmfIX1e.png)

![](https://i.imgur.com/5X5thNV.png)

![a](https://imgur.com/MO1Jnkq.gif)

**Resultado:**
- El plano, con rigidbody, desciende por la gravedad
- La esfera, con rigidbody y material HighFriction, desciende por la gravedad
- El cubo, con rigidbody,desciende por la gravedad

La esfera tiene material HighFriction esto hará que cuando toque el cubo o el plano se frene debido a la fricción, aun así la situación sigue siendo que todos elementos descienden a la misma velocidad y no colisionan unos con otros.

HighFriction material no parece afectar a la velocidad que desciendo pues va a la misma que anteriormente, parece que el elemento de fricción solo aporta resistencia con otras superficies y no con el "aire".
### Situación 8
El plano es un objeto físico. El cubo es un objeto físico y la esfera no es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.

![](https://i.imgur.com/n1oruJX.png)

![a](https://imgur.com/NIkgAxS.gif)

**Resultado:**
- El plano y el cubo caen de manera normal
- La esfera que al ser un trigger es ignorada por el motor de físicas y por lo tanto no colisionará con los demás objetos, y además al ser trigger podría activar eventos como detección de entrada/salida de un área si otros objetos entran en su volumen. La esfera al ser no física no se ve afectada por la gravedad.
### Situación 9
El plano es un objeto físico. El cubo es un objeto físico y la esfera es física y es Trigger. En este caso, todos los objetos deben tener Rigidbody.

![a](https://imgur.com/MO1Jnkq.gif)

**Resultado:**
- El plano, el cubo y la esfera caen de manera normal
- La esfera que al ser un trigger es ignorada por el motor de físicas y por lo tanto no colisionará con los demás objetos de manera que si colisianse con ellos los atravesaría, al ser trigger podría activar eventos como detección de entrada/salida de un área si otros objetos entran en su volumen.

## Ejercicio Físicas 3D - Scripts
