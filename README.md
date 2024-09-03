# DevPortal-AI-Kit
Build apps with QED APIs using AI.

DevPortal AI Kit combines 
 - Microsoft Semantic Kernel for parsing and managing your LLM queries
 - DevPortal Semantic Kernel Plugin for accessing QED API metadata
 - Ollama for managing a locally running LLM model
 - llama3.1 model

To get started:

First clone this repo
```console
git clone https://github.com/qed-developerportal/devportal-ai-kit.git
cd devportal-ai-kit
```

Open this repo in VS Code
```console
code .
```

Install Ollama (see https://github.com/ollama/ollama?tab=readme-ov-file for different ways to do this)
Open a new terminal window
Type the following to download and run the llama3.1:latest model
```console
ollama run llama3.1
```

Go back to your VS Code window, open a terminal and type
```console
dotnet run
```

This should bring you to a "User:" prompt where you can type a query such as "What API Groups are supported?" and press enter.

You should then see a response that has been generated.


