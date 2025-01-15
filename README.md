# **JetPack Genious**

Math Tube Challenge is een educatieve Unity-game waarin spelers wiskundige sommen oplossen door naar de juiste tube te navigeren. De game biedt eindeloze sommen en een uitdagende gameplay waarbij snelheid en nauwkeurigheid essentieel zijn!

---

## **Features**

- 🎮 **Play-knop**: Start de game met een eenvoudige klik.
- ➕ **Random Sommen**: Eindeloze sommen met willekeurige getallen.
- 🛠️ **Dynamische Gameplay**: Het correcte antwoord bevindt zich telkens op een andere tube.
- ⏳ **Tijdslimiet**: Los de som op voordat de tijd op is.
- ❌ **Fouten Feedback**: Kies je een verkeerde tube? De speler wordt gestunt!
- ✅ **Oneindige Uitdaging**: Speel door totdat je verliest.

---

## **Installatie**

Volg deze stappen om de game lokaal te draaien:

1. **Clone de repository**:
   ```bash
   git clone https://github.com/jouw-gebruikersnaam/math-tube-challenge.git
   cd math-tube-challenge
   ```

2. **Open het project in Unity**:
   - Zorg ervoor dat Unity is geïnstalleerd.
   - Open de projectmap via Unity Hub of rechtstreeks in Unity.

3. **Speel de game**:
   - Klik op de **Play-knop** in de Unity-editor of bouw de game naar een platform naar keuze.

---

## **Gameplay**

### **Hoe te spelen:**
1. Start de game door op de **Play-knop** te klikken.
2. Bekijk de wiskundige som bovenaan het scherm.
3. Navigeer je speler naar de tube met het correcte antwoord.
4. Beantwoord de sommen zo snel mogelijk om punten te scoren.
5. Blijf spelen tot je af bent!

### **Controls**:
- Gebruik de **pijltjestoetsen** of **WASD** om je speler te bewegen.
- Navigeer door de tubes om antwoorden te selecteren.

---

## **Projectstructuur**

- **Assets/Scripts**:
  - `GameManager.cs`: Beheert de game-logica, tijd en sommen.
  - `UI.cs`: Beheert de gebruikersinterface (probleemtekst, timer, startscherm).
  - `Tube.cs`: Detecteert spelerinteracties met tubes.
  - `PlayerController.cs`: Verantwoordelijk voor de beweging van de speler.
  
- **Scenes**:
  - `MainScene`: Bevat de volledige gameplayomgeving.

---

## **Technische Details**

- **Engine**: Unity (2020.3.0 LTS of hoger)
- **Programmeertaal**: C#
- **Platformen**: Windows, macOS, WebGL (compatibel met andere Unity-exportopties)
- **Gameplaymechanieken**:
  - Random gegenereerde wiskundige sommen.
  - Dynamische verdeling van correcte en incorrecte antwoorden.

---

## **Toekomstige Updates**

- 🚀 Meerdere moeilijkheidsgraden.
- 🏆 Leaderboards voor highscores.
- 🎨 Verbeterde visuals en animaties.
- 📱 Ondersteuning voor mobiele apparaten.

---

## **Bijdragen**

Contributies zijn welkom! Volg deze stappen om bij te dragen:

1. Fork deze repository.
2. Maak een nieuwe feature branch:
   ```bash
   git checkout -b feature/nieuwe-feature
   ```
3. Commit je wijzigingen:
   ```bash
   git commit -m "Voeg nieuwe feature toe"
   ```
4. Push naar je branch:
   ```bash
   git push origin feature/nieuwe-feature
   ```
5. Open een pull request.

---

## **Licentie**

Deze game valt onder de [MIT-licentie](LICENSE). Voel je vrij om de game aan te passen en te verspreiden!

---
