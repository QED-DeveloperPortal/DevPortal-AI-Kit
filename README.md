# DevPortal-AI-Kit
Build apps with QED APIs using AI.

DevPortal AI Kit combines 
 - Microsoft Semantic Kernel for parsing and managing your LLM queries
 - DevPortal Semantic Kernel Plugin for accessing QED API metadata
 - Ollama for managing a locally running LLM model
 - llama3.1 model

To get started:

First clone this repo with
```console
git clone https://github.com/qed-developerportal/devportal-ai-kit.git
cd devportal-ai-kit
```

Open this repo in VS Code with
```console
code .
```

Install Ollama (see https://github.com/ollama/ollama?tab=readme-ov-file for different ways to do this).

Open a new terminal window.

Type the following to download and run the llama3.1:latest model
```console
ollama run llama3.1
```

Go back to the VS Code window, open a terminal and type
```console
dotnet run
```

A "User:" prompt will show. 

Type a query such as "What API Groups are supported?" and press enter.

If everything is configured correctly a response will be generated.


<span style="color:green;font-weight:700;font-size:20px">
Example Questions
</span>

Here are a sample set of questions you can now ask the Semantic Kernel to process along with example answers it has previously provided.

```console
What API Categories are supported?
```

<span style="color:green;font-weight:700;font-size:16px">
The API Categories supported are:

1. Consent Management
2. Attendance/Roll Marking
3. Booking Systems
4. DoE Test Clients
5. Library Management Systems (online)
6. SMS/Text Messaging Providers
7. Student Management
8. Student Management Publisher
</span>




