# Interfaces Inteligentes - Práctica 3 - Físicas

**Autor:** Marcos Llinares Montes (alu0100972443)

## Índice
- [Ejercicio Físicas 3D](#ejercicio-físicas-3d)
  - [Situación 1](#situación-1)
  - [Situación 2](#situación-2)
  - [Situación 3](#situación-3)
  - [Situación 4](#situación-4)
  - [Situación 5](#situación-5)
  - [Situación 6](#situación-6)
  - [Situación 7](#situación-7)
  - [Situación 8](#situación-8)
  - [Situación 9](#situación-9)
- [Ejercicio Físicas 3D - Scripts](#ejercicio-físicas-3d---scripts)
  - [Ejercicio 1](#ejercicio-1)
  - [Ejercicio 2](#ejercicio-2)
  - [Ejercicio 3](#ejercicio-3)
  - [Ejercicio 4](#ejercicio-4)
  - [Ejercicio 5](#ejercicio-5)

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
### Ejercicio 1
Crea un personaje,controla su desplazamiento con las teclas WASD o las flechas, el movimiento debe estar influenciado por usando un Rigidbody, pero manteniendo el control total.

![a](https://imgur.com/ofLJB5l.gif)

```csharp
    public float moveSpeed = 10f;      // velocidad de movimiento

    Rigidbody rb;

    void Awake(){ rb = GetComponent<Rigidbody>(); }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal"); // A/D o flechas
        float v = Input.GetAxis("Vertical");   // W/S o flechas
        Vector3 input = new Vector3(h, 0, v);

        // Movimiento básico WASD - usando VelocityChange para respuesta inmediata
        Vector3 movement = input * moveSpeed;
        // rb.AddForce(movement, ForceMode.VelocityChange);
        rb.AddForce(movement, ForceMode.Force);
    }
```

### Ejercicio 2
Crea varios cubos o esferas con Rigidbody dinámico. Muestra por consola el nombre del objeto con el que colisiona, y cámbiale su color al colisionar.

![a](https://imgur.com/gEG0HwG.gif)

![|250](https://i.imgur.com/RxXr5Q0.png)

```csharp
    Renderer rend;

    void Awake(){
        rend = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision c)
    {
        // Solo cambiar color si colisiona con el player
        if (c.collider.GetComponent<PlayerControllerRB>() != null)
        {
            Debug.Log($"{name} colisionó con: {c.collider.name}");
            if (rend != null) rend.material.color = RandomColor();
        }
    }

    Color RandomColor() => new Color(Random.value, Random.value, Random.value);
```
### Ejercicio 3
Crea una zona (por ejemplo, un cubo grande con `Is Trigger = true`). Al entrar, cambia el color del personaje o activa un efecto que cambie la luz. Al salir, revierte el cambio. Añade otra zona que aumente una variable daño.

![a](https://imgur.com/EyYbIhn.gif)

![](https://i.imgur.com/EPpVA9z.png)

**ColorChangeZone**
```csharp
    void OnTriggerEnter(Collider other)
    {
        // Verificar si es el player
        PlayerControllerRB player = other.GetComponent<PlayerControllerRB>();
        if (player != null)
        {
            // Cambiar color del player
            Renderer playerRenderer = other.GetComponent<Renderer>();
            if (playerRenderer != null)
            {
                // Guardar color original si no existe
                PlayerColorManager colorManager = other.GetComponent<PlayerColorManager>();
                if (colorManager == null)
                {
                    colorManager = other.gameObject.AddComponent<PlayerColorManager>();
                    colorManager.originalColor = playerRenderer.material.color;
                }
                
                playerRenderer.material.color = zoneColor;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        // Verificar si es el player
        PlayerControllerRB player = other.GetComponent<PlayerControllerRB>();
        if (player != null)
        {
            // Restaurar color original del player
            Renderer playerRenderer = other.GetComponent<Renderer>();
            PlayerColorManager colorManager = other.GetComponent<PlayerColorManager>();
            
            if (playerRenderer != null && colorManager != null)
            {
                playerRenderer.material.color = colorManager.originalColor;
            }
        }
    }
```

**DamageZone**
```csharp
public class DamageZone : MonoBehaviour
{
    [Header("Configuración de Daño")]
    public float damageAmount = 10f;     // Cantidad de daño por entrada

    void OnTriggerEnter(Collider other)
    {
        // Verificar si es el player
        PlayerControllerRB player = other.GetComponent<PlayerControllerRB>();
        if (player != null)
        {
            // Buscar componente de salud del player
            PlayerHealth playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damageAmount);
                Debug.Log($"Player entró en zona de daño - Daño aplicado: {damageAmount}");
            }
        }
    }
}
```

**PlayerHealth**
```csharp
public class PlayerHealth : MonoBehaviour
{
    public float damage = 0f;  // Variable de daño acumulado
    
    public void TakeDamage(float damageAmount)
    {
        damage += damageAmount;
        Debug.Log($"Player recibió {damageAmount} de daño. Daño total: {damage}");
    }
}
```
### Ejercicio 4
Crea tres tipos de objetos en capas distintas: jugador, enemigos, recolectables. Configura la Layer Collision Matrix (Project Settings > Physics). Haz que los enemigos solo colisionen con el jugador, y que los recolectables solo sean detectados por triggers.

![a](https://imgur.com/IbZMCp5.gif)

![|300](https://i.imgur.com/KG5JrnI.png)

![|300](https://i.imgur.com/jJeHJky.png)

- Cada tipo de objeto tiene su layer correctamente asignado y Collectible (Coins) tienen Is Trigger activado

```csharp
public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Debug.Log($"Recolectado por: {other.name}");
            Destroy(gameObject);
        }
    }
}
```
### Ejercicio 5
Crea una escena con distintos materiales físicos (resbaladizo, rugoso, rebote alto). Aplica distintos Physic Materials a objetos. Lanza los objetos con AddForce() al pulsar la tecla X y observa cómo cambian las reacciones.

![a](https://imgur.com/JZ49iBg.gif)

- Slippery -> azul
- Rough -> rojo
- Bounce -> verde

![](https://i.imgur.com/0q33L4i.png)


```csharp
    public float force = 500f;
    public Vector3 direction = Vector3.up;

    Rigidbody rb;

    void Awake(){ rb = GetComponent<Rigidbody>(); }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(direction.normalized * force);
        }
    }
```