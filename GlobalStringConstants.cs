﻿namespace ZModLauncher;

public class GlobalStringConstants
{
    public const string GamesSectionTitle = "Games";
    public const string LaunchNowStatus = "Launch Now";
    public const string EnabledStatus = "Enabled";
    public const string DisabledStatus = "Disabled";
    public const string TogglingStatus = "Toggling...";
    public const string ComingSoonStatus = "Coming Soon";
    public const string DownloadStatus = "Download";
    public const string UpdateStatus = "Update";
    public const string DownloadingStatus = "Downloading";
    public const string UpdatingStatus = "Updating";
    public const string QueuingStatus = "Queuing...";
    public const string ReconnectingStatus = "Reconnecting...";
    public const string NotInstalledStatus = "Not Downloaded";
    public const string PlayNowStatus = "Play Now";
    public const string InstallingStatus = "Installing...";
    public const string WaitingStatus = "Waiting...";
    public const string GamesDbFileName = "games.json";
    public const string ModsDbFileName = "mods.json";
    public const string ManifestFileName = "native.manifest";
    public const string DefaultCardImageKey = "DefaultCardImage";
    public const string RefreshButtonAnimKey = "RefreshButtonAnim";
    public const string MainPageName = "MainPage";
    public const string LoadingPageName = "LoadingPage";
    public const string SettingsPageName = "SettingsPage";
    public const string SignInPageName = "SignInPage";
    public const string NoInternetResponse = "__jstcache";
    public const string ActivePatronStatus = "active_patron";
    public const string DeclinedPatronStatus = "declined_patron";
    public const string ManifestGamesKey = "Games";
    public const string ManifestModsKey = "Mods";
    public const string ManifestLocalPathKey = "LocalPath";
    public const string ManifestHasRunIntegrityCheckKey = "HasRunIntegrityCheck";
    public const string ManifestStatusKey = "Status";
    public const string ManifestVersionKey = "Version";
    public const string GamesDatabaseLocalPathKey = "LocalPath";
    public const string DatabaseExecutableKey = "ExecutablePath";
    public const string ModsDatabaseNativeMacroKey = "NativeToggleMacroPath";
    public const string ModsDatabaseSharedMacroKey = "IsUsingSharedToggleMacro";
    public const string ModsDatabaseModInfoUriKey = "ModInfoUri";
    public const string ModsDatabaseDirectDownloadUriKey = "DirectDownloadUri";
    public const string EpicGamesGameNameKey = "DisplayName";
    public const string EpicGamesInstallLocKey = "InstallLocation";
    public const string PatreonRedirectUriKey = "PatreonRedirectUri";
    public const string PatreonClientIdKey = "PatreonClientId";
    public const string PatreonClientSecretKey = "PatreonClientSecret";
    public const string PatreonCreatorUrlKey = "PatreonCreatorUrl";
    public const string DropboxRefreshTokenKey = "DropboxRefreshToken";
    public const string DropboxClientIdKey = "DropboxClientId";
    public const string DropboxClientSecretKey = "DropboxClientSecret";
    public const string YouTubeResourceLinkKey = "YouTubeResourceLink";
    public const string TwitterResourceLinkKey = "TwitterResourceLink";
    public const string RoadmapResourceLinkKey = "RoadmapResourceLink";
    public const string FAQResourceLinkKey = "FAQResourceLink";
    public const string PrepareLauncherMessageLinkKey = "PrepareLauncherMessage";
    public const string RejectTierIdKey = "RejectTierId";
    public const string IsLauncherOfflineForMaintenanceKey = "IsLauncherOfflineForMaintenance";
    public const string OpenZipFileFilter = "ZIP File (*.zip)|*.zip";
    public const string InstallLocalModPrompt = "Select a local mod zip file to install...";
    public const string GameInstallFolderPrompt = "Select the game's installation folder:";
    public const string InstallLocalModSuccessMessage = "The local mod has successfully been installed!";
    public const string DeleteModConfirmation = "Are you sure you want to delete this mod?";
    public const string ClearLauncherCacheConfirmation = "Are you sure you want to clear the cache? It is not recommended unless absolutely necessary.";
    public const string AppPermissionsError = "The launcher does not appear to be configured correctly, ensure that you have Microsoft Edge installed.";
    public const string ZipAccessError = "The mod's archive is being used by another process, the download will attempt to re-queue.";
    public const string NotEnoughSpaceError = "There is not enough space to download/extract the mod, please try again later.";
    public const string LauncherResourceClearError = "The requested launcher resource could not be cleared.";
    public const string InternetConnectionError = "A network connection could not be established to check for launcher updates, do you want to retry?";
    public const string ZipFormatError = "The mod's archive was delivered in an incorrect format, please have the developers re-upload it.";
    public const string GameExecutableError = "The game's executable or online database could not be read.";
    public const string ModExecutableError = "The mod's executable or online database could not be read.";
    public const string LauncherConfigError = "The internal launcher configuration could not be read.";
    public const string LauncherMaintenanceMessage = "The launcher is currently offline for mandatory maintenance, please try again later.";
    public static readonly string LauncherConfigName = $"{NativeManifest.ActualAppName}.launcherconfig.json";
}