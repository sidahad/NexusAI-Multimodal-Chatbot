# NexusAI - Multimodal .NET Chatbot

NexusAI is an advanced, feature-rich AI assistant built using the .NET ecosystem. This chatbot goes beyond standard text interactions by integrating multimodal capabilities, allowing users to interact via text, images, and voice. It delivers dynamic outputs in both textual and spoken formats while maintaining a continuous chat history.

---

## Features

### Multimodal Input Support
* **Text Prompts:** Standard conversational AI interface for text-based queries and code generation.
* **Image Prompts (Vision):** Ability to upload images for description, object detection, and contextual analysis.
* **Voice Prompts (Speech-to-Text):** Integrated microphone support that captures user audio and translates it into actionable prompts.

### Dual Output Experience
* **Text Response:** Clean, formatted textual replies with support for code syntax highlighting.
* **Voice Response (Text-to-Speech):** Automated audio playback that reads out the AI generated response dynamically.

### Session and History Management
* **Persistent Chat History:** Saves past conversations, user prompts, and AI responses to a local or cloud database for seamless context retention across sessions.

---

## Tech Stack

* **Framework:** .NET (ASP.NET Core / Blazor / WPF / .NET MAUI depending on your UI)
* **AI Ecosystem:** Semantic Kernel / Azure OpenAI SDK / OpenAI API
* **Cognitive Services:** Azure Speech Services (or OpenAI Whisper/TTS) for Voice Processing
* **Database:** Entity Framework Core (SQL Server / SQLite) for persistent history
* **Frontend:** HTML5, CSS3, JavaScript / Razor Components

---

## Prerequisites

Before running the application, ensure you have the following configured:
* .NET SDK (Version 8.0 or later)
* API Keys for OpenAI, Azure Cognitive Services, or Gemini API
* A local database setup (if using SQL Server)

---

## Installation and Setup

Follow these steps to run the project locally:

### 1. Clone the Repository
```bash
git clone [https://github.com/sidahad/NexusAI-Multimodal-Chatbot.git](https://github.com/sidahad/NexusAI-Multimodal-Chatbot.git)
