namespace DevPortalAIKit.Plugins.Utils;

/// <summary>
/// Global variables for prompt generation.
/// </summary>
public static class ConstantUtils
{
  // URL for DevPortal Plugin
  public const string ApiBaseUrl = "https://dp-mockaco.azurewebsites.net/";
  
  // The LLM Model to be used by Ollama
  public const string ModelId = "llama3.1:latest";

  // Default URL for Ollama
  public const string BaseUrl = "http://localhost:11434";
}

