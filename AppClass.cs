using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheatEnginePortableInstall
{
	internal class AppClass
	{
		private static string FileMD5 = "1e6f9b50ae43a8176313237279571ced";

		private static string SetInstallPath()
		{
			using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
			{
				folderBrowserDialog.Description = "请选择安装目录";
				folderBrowserDialog.ShowNewFolderButton = true;

				if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
				{
					string selectedPath = folderBrowserDialog.SelectedPath;
					string subDirectoryPath = Path.Combine(selectedPath, "Cheat Engine 7.5"); // 替换为你想要的子目录名称

					// 创建子目录
					Directory.CreateDirectory(subDirectoryPath);

					return subDirectoryPath; // 返回选择的目录
				}
				return string.Empty;
			}
		}

		public static void Install() 
		{
			string installPath = SetInstallPath();
			string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cheat Engine 7.5.zip");
			string exePath = Path.Combine(installPath, "Cheat Engine.exe"); // 假设可执行文件名为 Cheat Engine.exe
			string shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "CE修改器便携式版 v7.5.lnk");

			try
			{
				if (!Directory.Exists(installPath))
				{
					Directory.CreateDirectory(installPath);
				}
				ZipFile.ExtractToDirectory(filePath, installPath);
				// 创建快捷方式
				CreateShortcut(exePath, shortcutPath);
				MessageBox.Show("安装成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Environment.Exit(0); // 退出进程

			}
			catch (Exception ex)
			{
				MessageBox.Show($"安装失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private static void CreateShortcut(string targetPath, string shortcutPath)
		{
			var shell = new IWshRuntimeLibrary.WshShell();
			var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);
			shortcut.TargetPath = targetPath;
			shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);
			shortcut.Description = "CE修改器便携式版 v7.5";
			shortcut.IconLocation = targetPath; // 使用可执行文件的图标
			shortcut.Save();
		}

		public static async Task<string> DownloadFile(ProgressBar progressBar)
		{
			string s = string.Empty;
			string downloadPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Cheat Engine 7.5.zip"); // 指定文件名和扩展名
			string fileUrl = "https://lanzou.fyaa.net/lanzou/?url=https%3A%2F%2Fduhuachen.lanzout.com%2FiVbQR28yg1tg&type=down";

			using (WebClient webClient = new WebClient())
			{
				try
				{
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
					webClient.DownloadProgressChanged += (sender, e) =>
					{
						progressBar.Value = e.ProgressPercentage;
					};
					await webClient.DownloadFileTaskAsync(new Uri(fileUrl), downloadPath);
					string calculatedMD5 = CalculateMD5(downloadPath);
					if (calculatedMD5.Equals(FileMD5, StringComparison.OrdinalIgnoreCase))
					{
						s = "文件下载成功！";
					}
					else
					{
						s = "文件下载失败，文件的MD5不匹配！";
					}
				}
				catch (WebException webEx)
				{
					s = "下载文件时发生网络错误: " + webEx.Message;
				}
				catch (Exception ex)
				{
					s = "下载文件时发生错误: " + ex.Message;
				}
			}
			return s;
		}

		private static string CalculateMD5(string filePath)
		{
			using (var md5 = MD5.Create())
			{
				using (var stream = File.OpenRead(filePath))
				{
					byte[] hash = md5.ComputeHash(stream);
					return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
				}
			}
		}
	}
}
