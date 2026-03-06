[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/ZXq9zVzz)
# Decorator Pattern – Bewegtes Objekt erweitern

## Ausgangssituation

In der Szene bewegt sich ein Objekt zwischen **Punkt A** und **Punkt B** hin und her.

Das Basisverhalten ist bereits implementiert.

Zusätzlich ist aktuell bereits ein weiteres Verhalten direkt in das Bewegungsscript eingebaut (z. B. Farbwechsel beim Richtungswechsel).  
Diese Lösung funktioniert, ist aber auf Dauer **schwer erweiterbar**.

---

## Problem

Wenn wir weitere Effekte hinzufügen wollen, z. B.:

- Rotation
- Glow / Glimmen
- Spur (Trail)
- Größenänderung
- Sound

würde die Bewegungsklasse immer größer werden.

Das verletzt ein wichtiges Prinzip der Softwareentwicklung:

> Eine Klasse sollte nur eine klar definierte Verantwortung haben.

---

## Ziel der Aufgabe

Das System soll so umgebaut werden, dass zusätzliche Effekte **modular erweitert** werden können, ohne die Basisklasse ständig zu verändern.

Dafür soll das **Decorator Pattern** verwendet werden.

---

# Gruppenarbeit

Ihr arbeitet in **3er-Gruppen**.

Jeder in der Gruppe entwickelt **genau einen Decorator**, der das Verhalten des bewegten Objekts erweitert.

Am Ende werden mehrere Decorators **kombiniert**.

---

# Teil 1 – Analyse

Besprecht in eurer Gruppe und beantwortet hier direkt:

1. Was ist das **Basisverhalten** des Programms?
2. Welches Verhalten gehört **nicht direkt** in die Basisklasse?
3. Warum wäre es problematisch, alle neuen Effekte direkt in derselben Klasse zu implementieren?

---

# Teil 2 – Refactoring

Baut das Projekt so um, dass:

- das **Basisverhalten isoliert** wird
- Erweiterungen **nicht direkt in der Bewegungsklasse** implementiert werden
- zusätzliche Effekte über **Decorator-Klassen** hinzugefügt werden können

---

# Teil 3 – Decorator implementieren

Jeder in der Gruppe implementiert **einen Decorator**.

Der Decorator soll das Verhalten sichtbar erweitern.

## Mögliche Decorators

- **RotateDecorator**  
  Das Objekt rotiert zusätzlich.

- **ColorDecorator**  
  Das Objekt ändert beim Richtungswechsel seine Farbe.

- **GlowDecorator**  
  Das Objekt glimmt oder pulsiert farblich.

- **ScaleDecorator**  
  Das Objekt verändert rhythmisch seine Größe.

- **TrailDecorator**  
  Das Objekt hinterlässt eine Spur.

- **SoundDecorator**  
  Beim Richtungswechsel wird ein Sound abgespielt.

- **SpeedDecorator**  
  Das Objekt verändert seine Geschwindigkeit.

- **DebugDecorator**  
  Zusätzliche Debug-Informationen werden angezeigt.

---

# Teil 4 – Kombination testen

Testet, ob mehrere Decorators kombiniert werden können.

# Teil 5 - Playthrough Video (<100MB) 

# Teil 6 - Vorbereitung einer Live Demo

# Teil 7 - UML
