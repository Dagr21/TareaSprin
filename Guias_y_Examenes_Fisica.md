# Guías de estudio y exámenes de práctica

Basado en las guías de laboratorio:
- **Tema 1:** Ley de Hooke y energía potencial elástica
- **Tema 2:** Conservación de la energía, péndulo simple (Experimento 8)
- **Tema 3:** Principios de Arquímedes y Pascal (Experimento 9)

Las respuestas de cada examen están al final de su tema. Intenta resolver primero sin mirar.

---

# TEMA 1: Ley de Hooke y energía potencial elástica

## Guía de estudio

| Concepto | Definición | Fórmula |
|---|---|---|
| Elasticidad | Propiedad de recuperar la forma original al cesar la fuerza externa | n/a |
| Cuerpo elástico | Se deforma bajo una fuerza y la recupera al quitarla (ej. resorte). Pasado su límite elástico queda deformado o se rompe | n/a |
| Deformación X | Cambio de longitud | X = L − L₀ |
| Fuerza de restauración | Igual magnitud y sentido contrario a la fuerza externa (3.ª ley de Newton) | F_ext = −F_x |
| Ley de Hooke | La fuerza de restauración es directamente proporcional a la deformación | F_x = −k·X |
| Constante elástica k | Medida de la rigidez del resorte | k = F/X (N/m) |
| Trabajo | Área bajo la gráfica F = f(X), un triángulo | W = ½·F·X |
| Energía potencial elástica | Energía almacenada por el cuerpo deformado | E_PE = ½·k·X² |

Ideas clave:
- El signo negativo indica que la fuerza de restauración va en sentido contrario a la deformación.
- E_PE es proporcional al **cuadrado** de X: si X se duplica, E_PE se cuadruplica.
- Unidades de E_PE: Joule (N·m) en el SI, ergio (dina·cm) en el cegesimal. 1 J = 10⁷ ergios.
- Peso de la masa colgante: F = m·g, con g = 9,80 m/s².
- Gráfica F vs X: recta por el origen, pendiente = k, área = trabajo.
- Gráfica E_PE vs X: parábola. Gráfica E_PE vs X²: recta por el origen, pendiente = k/2.
- El cociente F/X es constante en un resorte ideal, y ese valor es k.
- Error común: olvidar el ½ en E_PE = ½·k·X².

## Examen de práctica

**Selección múltiple**
1. La ley de Hooke establece que la fuerza de restauración es:
   a) inversamente proporcional a la deformación  b) directamente proporcional a la deformación  c) proporcional al cuadrado de la deformación  d) independiente de la deformación
2. La unidad de la constante elástica en el SI es:
   a) N  b) J  c) N/m  d) N·m
3. La energía potencial elástica se calcula con:
   a) k·X  b) ½·k·X  c) ½·k·X²  d) k·X²
4. Si la deformación se triplica, la energía potencial elástica:
   a) se triplica  b) se multiplica por 6  c) se multiplica por 9  d) no cambia
5. En la gráfica E_PE vs X², la pendiente es:
   a) k  b) k/2  c) 2k  d) k²

**Verdadero o falso**
6. El signo negativo en F = −kX indica que la fuerza va en sentido opuesto a la deformación.
7. Un resorte recupera siempre su forma, sin importar cuánta fuerza se aplique.
8. 1 J = 10⁷ ergios.

**Problemas**
9. Un resorte se estira 0,20 m al colgarle una masa de 2 kg (g = 9,8 m/s²). Calcula k.
10. Con ese resorte, ¿cuánta energía almacena al deformarse 0,10 m?
11. Un resorte con k = 50 N/m soporta una fuerza de 5 N. ¿Cuánto se deforma y cuánta energía almacena?

**Desarrollo**
12. Define fuerza de restauración y explica por qué existe, citando la ley de Newton correspondiente.
13. ¿Qué representa el área bajo la gráfica F = f(X)?

### Respuestas Tema 1
1) b  2) c  3) c  4) c  5) b  6) V  7) F (solo dentro del límite elástico)  8) V
9) F = 2·9,8 = 19,6 N → k = 19,6/0,20 = **98 N/m**
10) E = ½·98·(0,10)² = **0,49 J**
11) X = F/k = 5/50 = **0,10 m**; E = ½·50·(0,10)² = **0,25 J**
12) Es la fuerza que ejerce el cuerpo elástico, de igual magnitud y sentido contrario a la fuerza externa (3.ª ley de Newton); ayuda al cuerpo a recuperar su forma original.
13) El trabajo realizado sobre el resorte, W = ½·F·X, que es la energía potencial elástica almacenada.

---

# TEMA 2: Conservación de la energía, péndulo simple

## Guía de estudio

| Concepto | Idea clave |
|---|---|
| Movimiento periódico | Se repite en intervalos de tiempo iguales |
| M.A.S. | Movimiento periódico donde la fuerza neta es proporcional a la posición |
| Péndulo simple | Hilo inextensible de masa despreciable con una masa colgante; oscila entre dos extremos pasando por el equilibrio |
| Longitud L | Del punto de suspensión al centro de la masa |
| Amplitud | Desplazamiento máximo desde el equilibrio |
| Oscilación | Movimiento completo de ida y vuelta |
| Periodo T | Tiempo de una oscilación |
| Por qué ≤ 15° | Para ángulos pequeños sen θ ≈ θ, y el movimiento es M.A.S. |

| Magnitud | Fórmula |
|---|---|
| Posición | x(t) = A·cos(ωt) |
| Frecuencia angular | ω = 2π/T |
| Velocidad | v(t) = −Aω·sen(ωt); v_máx = Aω |
| Aceleración | a(t) = −Aω²·cos(ωt); a_máx = Aω² |
| Energía cinética | E_c = ½·m·v² |
| Energía potencial gravitatoria | E_pg = m·g·h |
| Energía mecánica | E_m = E_c + E_pg = constante |
| Altura | h = Δx²/(2L), con Δx = x − x₀ |

Derivación de h: L² = (L−h)² + Δx² → 0 = −2Lh + h² + Δx². Como h² ≈ 0, h = Δx²/(2L).

| Magnitud | Equilibrio | Extremos |
|---|---|---|
| Velocidad y E_c | Máxima | Mínima (0) |
| Aceleración | Mínima (0) | Máxima |
| Altura y E_pg | Mínima (0) | Máxima |
| E_m | Constante | Constante |

- Desfase: la velocidad va 90° respecto a la posición; la aceleración, 180°.
- Principio de conservación: en un sistema aislado la energía total es constante; solo se transforma entre potencial y cinética.
- Periodo (fórmula estándar, no aparece en las páginas de la guía): T = 2π√(L/g). Depende de L y g, **no** de la masa ni (para ángulos pequeños) de la amplitud.
- En el laboratorio la E_m varía un poco por la fricción y el error de medición.
- Errores comunes: E_c nunca es negativa; x₀ se toma donde la velocidad es máxima.

## Examen de práctica

**Selección múltiple**
1. En el punto de equilibrio del péndulo, la energía cinética es:
   a) mínima  b) máxima  c) igual a la potencial  d) cero
2. En los extremos de la oscilación es máxima:
   a) la velocidad  b) la energía cinética  c) la aceleración  d) la energía mecánica
3. Si la longitud del péndulo se cuadruplica, el periodo:
   a) se duplica  b) se cuadruplica  c) se reduce a la mitad  d) no cambia
4. La masa del péndulo, ¿cómo afecta al periodo?
   a) lo aumenta  b) lo disminuye  c) no lo afecta  d) lo duplica
5. La altura alcanzada por el péndulo se calcula con:
   a) Δx/2L  b) Δx²/2L  c) 2L/Δx²  d) L/Δx

**Verdadero o falso**
6. La energía mecánica del péndulo ideal es constante.
7. La aceleración del M.A.S. está desfasada 90° respecto a la posición.
8. Se exige un ángulo ≤ 15° para que el movimiento sea aproximadamente M.A.S.

**Problemas**
9. Péndulo de L = 1,50 m con Δx = 0,20 m. Calcula h.
10. Péndulo de L = 2,0 m, m = 0,40 kg, Δx = 0,20 m (g = 9,8). Calcula h y E_pg en ese punto.
11. Con los datos del problema 10, ¿cuánta E_c y qué velocidad tiene al pasar por el equilibrio (sin pérdidas)?
12. ¿Cuál es el periodo de un péndulo de L = 1,0 m (g = 9,8)? ¿Y ω?
13. Con A = 0,10 m y ω = π rad/s, calcula v_máx y a_máx.

**Desarrollo**
14. Explica por qué en el laboratorio la energía mecánica no es perfectamente constante.
15. Define movimiento periódico y M.A.S. y diferéncialos.

### Respuestas Tema 2
1) b  2) c  3) a  4) c  5) b  6) V  7) F (180°)  8) V
9) h = 0,20²/(2·1,50) = 0,04/3 = **0,0133 m**
10) h = 0,04/(2·2,0) = **0,010 m**; E_pg = 0,40·9,8·0,010 = **0,0392 J**
11) Sin pérdidas, E_c = **0,0392 J**; v = √(2·E_c/m) = √(0,196) ≈ **0,44 m/s**
12) T = 2π√(1,0/9,8) ≈ **2,0 s**; ω = 2π/T ≈ **3,13 rad/s**
13) v_máx = Aω = 0,10·π ≈ **0,314 m/s**; a_máx = Aω² = 0,10·π² ≈ **0,987 m/s²**
14) Hay fricción con el aire y en el punto de suspensión, que disipa energía como calor, y hay error en la medición de posición y velocidad.
15) Periódico: se repite en intervalos de tiempo iguales. M.A.S.: además la fuerza neta es proporcional a la posición.

---

# TEMA 3: Principios de Arquímedes y Pascal

## Guía de estudio

**Fluidos:** sustancias en estado líquido o gaseoso, cuyas partículas se mueven con gran facilidad entre sí (fluyen) y se reordenan bajo cualquier fuerza externa.
- Sólidos: partículas con fuerzas de interacción fuertes; forma fija.
- Líquidos: fuerzas más débiles; adoptan la forma del recipiente.
- Gases: fuerzas aún más débiles; ocupan todo el volumen del recipiente.
- En fluidos confinados en equilibrio se estudian su volumen, su densidad y los cambios de presión.

**Principio de Arquímedes:** "Todo cuerpo sumergido en un fluido (líquido o gas) recibe un empuje de abajo hacia arriba igual al peso del fluido desalojado."

| Magnitud | Definición / fórmula |
|---|---|
| Peso real P_R | Peso del objeto fuera del fluido |
| Peso aparente P_A | Peso que aparenta tener dentro del fluido |
| Empuje F_E | F_E = P_R − P_A (9.1); misma dirección y sentido contrario al peso |
| Volumen desalojado | V = V_f − V_i (9.2) |
| Densidad | D = m/V, de donde m = D·V |
| Peso del fluido desalojado | P = D·V·g (9.3) |

- Comprobación: los resultados de (9.1) y (9.3) deben ser iguales o muy cercanos.
- Por la **impenetrabilidad**, dos cuerpos no pueden ocupar el mismo lugar al mismo tiempo: el cuerpo desaloja fluido, y a más fluido desalojado, mayor empuje.
- Densidad del agua: 1,00 × 10³ kg/m³. Para el volumen: 1 mL = 1 cm³ = 10⁻⁶ m³.
- Aplicaciones: barcos, submarinos (tanque de lastre: entra agua para bajar, se expulsa para subir) y globos aerostáticos.

**Presión:** cantidad escalar, fuerza normal (perpendicular) por unidad de área: P = F/A (9.4). En el SI: 1 Pa = 1 N/m².

**Principio de Pascal:** "La diferencia de presión a la que se somete un fluido en reposo se distribuye totalmente a cada punto del fluido y las paredes del recipiente que lo contiene."
- En dos émbolos conectados: P₁ = P₂ → F₁/A₁ = F₂/A₂ (9.5).
- Aplicaciones (máquinas multiplicadoras de fuerza): frenos hidráulicos, elevadores, cortadoras, prensas, forjadoras y gatos hidráulicos.

**Respuestas a las preguntas de la guía**
- Exploración 1 (banda y piedra): la banda se estira más con la piedra **fuera del agua**. Al sumergirla, el empuje reduce el peso aparente y la banda se contrae.
- Exploración 2 (huevo en agua): se hunde, porque su densidad es mayor que la del agua y el empuje es menor que su peso.
- Exploración 3 (sal): al disolver sal sube la densidad del agua, aumenta el empuje y el huevo flota.
- Exploración 4 (cuerpo en agua): se aparenta menos peso por el empuje del agua.
- Procedimiento II, a): la fuerza es **mayor en la jeringa grande**. b) La presión se transmite igual (F₁/A₁ = F₂/A₂), y a mayor área, mayor fuerza.

Nota: en los procedimientos de la guía que me mandaste, las tablas y los espacios están **en blanco**, así que no tengo datos tuyos que revisar para este tema.

## Examen de práctica

**Selección múltiple**
1. El empuje que recibe un cuerpo sumergido es igual a:
   a) su peso real  b) el peso del fluido desalojado  c) su volumen  d) su densidad
2. El empuje se calcula como:
   a) P_R + P_A  b) P_R − P_A  c) P_A − P_R  d) P_R / P_A
3. El peso del fluido desalojado se calcula con:
   a) D·V  b) D·V·g  c) m/V  d) V_f + V_i
4. La unidad de presión en el SI es:
   a) N  b) J  c) Pa (N/m²)  d) kg/m³
5. Según el principio de Pascal, la presión aplicada a un fluido confinado:
   a) se pierde  b) se transmite a todo el fluido  c) solo llega al fondo  d) aumenta al transmitirse
6. Son aplicaciones del principio de Pascal:
   a) barcos y submarinos  b) globos aerostáticos  c) frenos hidráulicos y gatos hidráulicos  d) dinamómetros

**Verdadero o falso**
7. El peso aparente es mayor que el peso real.
8. Un huevo flota mejor en agua salada que en agua dulce.
9. Un submarino controla su profundidad variando el agua en su tanque de lastre.

**Problemas**
10. Un objeto pesa 5,0 N en el aire y 2,55 N sumergido. ¿Cuánto vale el empuje?
11. Un objeto desaloja 250 cm³ de agua (D = 1000 kg/m³, g = 9,8). Calcula el peso del fluido desalojado.
12. Una fuerza de 50 N actúa sobre un área de 0,010 m². Calcula la presión.
13. En una prensa hidráulica, F₁ = 20 N, A₁ = 4 cm² y A₂ = 100 cm². Calcula F₂.
14. En una probeta, V_i = 80 mL y V_f = 130 mL tras sumergir un cuerpo. Calcula el volumen desalojado en m³ y el peso del agua desalojada.

**Desarrollo**
15. Explica por qué un barco de acero flota.
16. ¿Qué se espera al comparar F_E y el peso del fluido desalojado en el laboratorio? Explica posibles diferencias.
17. En el experimento de las dos jeringas, ¿en cuál se necesita más fuerza y por qué?

### Respuestas Tema 3
1) b  2) b  3) b  4) c  5) b  6) c  7) F  8) V  9) V
10) F_E = 5,0 − 2,55 = **2,45 N**
11) V = 250 × 10⁻⁶ = 2,5 × 10⁻⁴ m³; P = 1000·2,5×10⁻⁴·9,8 = **2,45 N** (coincide con el 10)
12) P = 50/0,010 = **5000 Pa**
13) F₂ = F₁·A₂/A₁ = 20·100/4 = **500 N**
14) V = 130 − 80 = 50 mL = 5,0 × 10⁻⁵ m³; P = 1000·5,0×10⁻⁵·9,8 = **0,49 N**
15) Porque su forma desaloja un gran volumen de agua, y el empuje iguala a su peso total. Lo importante es su densidad promedio (casco hueco con aire), no la del acero.
16) Deben ser iguales o muy cercanos. Las diferencias se deben a errores de lectura del dinamómetro y de la probeta, y a efectos de superficie del agua o burbujas.
17) En la jeringa **grande**: la presión es la misma en ambas, y como F = P·A, mayor área exige mayor fuerza. A cambio, el émbolo pequeño recorre más distancia para desplazar el mismo volumen.

---

# SIMULACRO MIXTO (los 3 temas)

1. Escribe la fórmula de la energía potencial elástica y de la energía potencial gravitatoria, y di qué las distingue.
2. Un resorte (k = 200 N/m) se comprime 5 cm. ¿Qué energía almacena? *(0,25 J)*
3. Un péndulo de L = 1,5 m pasa por Δx = 0,30 m. Calcula h. *(0,03 m)*
4. ¿Por qué el huevo flota al agregar sal? ¿Qué magnitud del fluido cambia?
5. Una prensa hidráulica multiplica la fuerza por 25. ¿Qué relación tienen sus áreas? *(A₂ = 25·A₁)*
6. Un objeto de peso real 8 N tiene peso aparente 6,5 N en agua. ¿Cuánto vale F_E y cuántos m³ de agua desaloja (g = 9,8; D = 1000)? *(1,5 N; ≈ 1,53 × 10⁻⁴ m³)*
7. Compara E_c y E_pg en el péndulo (dónde es máxima cada una).
8. ¿Qué tienen en común el principio de conservación de la energía y el principio de Pascal? (Ambos hablan de algo que se conserva o se transmite en un sistema ideal.)
