using Newtonsoft.Json;
using Nuki.Enumeration;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nuki.Endpoint
{
    public static class Smartlock
    {
        /// <summary>
        /// Get a list of Smartlocks
        /// </summary>
        /// <returns></returns>
        public static async Task<Model.Smartlock[]> GetSmartlocksAsync()
        {
            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.GetAsync($"smartlock");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Model.Smartlock[]>(responseString);
            }
        }

        /// <summary>
        /// Create a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <param name="authUuid"></param>
        /// <param name="authSecret"></param>
        /// <returns></returns>
        public static async Task<Model.Smartlock> PutSmartlockAsync(Model.Smartlock smartlock, string authUuid, string authSecret)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("smartlockId", $"{smartlock.SmartlockId}"),
              new KeyValuePair<string, string>("type", $"{smartlock.Type}"),
              new KeyValuePair<string, string>("name", $"{smartlock.Name}"),
              new KeyValuePair<string, string>("authUuid", $"{authUuid}"),
              new KeyValuePair<string, string>("authId", $"{smartlock.AuthId}"),
              new KeyValuePair<string, string>("authSecret", $"{authSecret}"),
              new KeyValuePair<string, string>("lmType", $"{smartlock.LmType}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PutAsync($"smartlock", requestParams);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Model.Smartlock>(responseString);
            }
        }

        /// <summary>
        /// Create a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="authUuid"></param>
        /// <param name="authId"></param>
        /// <param name="authSecret"></param>
        /// <param name="lmType"></param>
        /// <returns></returns>
        public static async Task<Model.Smartlock> PutSmartlockAsync(int smartlockId, int type, string name, string authUuid, int authId, string authSecret, int lmType)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("smartlockId", $"{smartlockId}"),
              new KeyValuePair<string, string>("type", $"{type}"),
              new KeyValuePair<string, string>("name", $"{name}"),
              new KeyValuePair<string, string>("authUuid", $"{authUuid}"),
              new KeyValuePair<string, string>("authId", $"{authId}"),
              new KeyValuePair<string, string>("authSecret", $"{authSecret}"),
              new KeyValuePair<string, string>("lmType", $"{lmType}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PutAsync($"smartlock", requestParams);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Model.Smartlock>(responseString);
            }
        }

        /// <summary>
        /// Delete a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> DeleteSmartlockAsync(Model.Smartlock smartlock)
        {
            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.DeleteAsync($"smartlock/{smartlock.SmartlockId}");
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Delete a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> DeleteSmartlockAsync(int smartlockId)
        {
            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.DeleteAsync($"smartlock/{smartlockId}");
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Get a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<Model.Smartlock> GetSmartlockAsync(Model.Smartlock smartlock)
        {
            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.GetAsync($"smartlock/{smartlock.SmartlockId}");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Model.Smartlock>(responseString);
            }
        }

        /// <summary>
        /// Get a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<Model.Smartlock> GetSmartlockAsync(int smartlockId)
        {
            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.GetAsync($"smartlock/{smartlockId}");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Model.Smartlock>(responseString);
            }
        }

        /// <summary>
        /// Update a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <param name="name"></param>
        /// <param name="favorite"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAsync(Model.Smartlock smartlock)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();

            allInputParams.Add(new KeyValuePair<string, string>("name", $"{smartlock.Name}"));
            allInputParams.Add(new KeyValuePair<string, string>("favorite", $"{smartlock.Favorite}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Update a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="name"></param>
        /// <param name="favorite"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAsync(int smartlockId, string name, bool favorite)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();

            allInputParams.Add(new KeyValuePair<string, string>("name", $"{name}"));
            allInputParams.Add(new KeyValuePair<string, string>("favorite", $"{favorite}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Lock & unlock a smartlock with options
        /// </summary>
        /// <param name="smartlock"></param>
        /// <param name="action"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionAsync(Model.Smartlock smartlock, SmartlockAction action, SmartlockOption option)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("action", $"{(int)action}"),
              new KeyValuePair<string, string>("option", $"{(int)option}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/action", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Lock & unlock a smartlock with options
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="action"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionAsync(int smartlockId, int action, int option)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("action", $"{action}"),
              new KeyValuePair<string, string>("option", $"{option}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/action", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Lock a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionLockAsync(Model.Smartlock smartlock)
        {
            var requestParams = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/action/lock", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Lock a smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionLockAsync(int smartlockId)
        {
            var requestParams = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/action/lock", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Unlock a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionUnlockAsync(Model.Smartlock smartlock)
        {
            var requestParams = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/action/unlock", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Unlock a smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockActionUnlockAsync(int smartlockId)
        {
            var requestParams = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/action/unlock", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock admin pin
        /// </summary>
        /// <param name="smartlock"></param>
        /// <param name="adminPin"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdminPinAsync(Model.Smartlock smartlock, int adminPin)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("adminPin", $"{adminPin}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/admin/pin", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock admin pin
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="adminPin"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdminPinAsync(int smartlockId, int adminPin)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("adminPin", $"{adminPin}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/admin/pin", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock advanced config
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdvancedConfigAsync(Model.Smartlock smartlock)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("lngTimeout", $"{smartlock.AdvancedConfig.LngTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleButtonPressAction", $"{smartlock.AdvancedConfig.SingleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("doubleButtonPressAction", $"{smartlock.AdvancedConfig.DoubleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{smartlock.AdvancedConfig.AutomaticBatteryTypeDetection}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlatchDuration", $"{smartlock.AdvancedConfig.UnlatchDuration}"));
            allInputParams.Add(new KeyValuePair<string, string>("operationId", $"{smartlock.AdvancedConfig.OperationId}"));
            allInputParams.Add(new KeyValuePair<string, string>("totalDegrees", $"{smartlock.AdvancedConfig.TotalDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleLockedPositionOffsetDegrees", $"{smartlock.AdvancedConfig.SingleLockedPositionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlockedToLockedTransitionOffsetDegrees", $"{smartlock.AdvancedConfig.UnlockedToLockedTransitionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlockedPositionOffsetDegrees", $"{smartlock.AdvancedConfig.UnlockedPositionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("lockedPositionOffsetDegrees", $"{smartlock.AdvancedConfig.LockedPositionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("detachedCylinder", $"{smartlock.AdvancedConfig.DetachedCylinder}"));
            allInputParams.Add(new KeyValuePair<string, string>("batteryType", $"{smartlock.AdvancedConfig.BatteryType}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoLock", $"{smartlock.AdvancedConfig.AutoLock}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoLockTimeout", $"{smartlock.AdvancedConfig.AutoLockTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoUpdateEnabled", $"{smartlock.AdvancedConfig.AutoUpdateEnabled}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/advanced/config", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock advanced config
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="lngTimeout"></param>
        /// <param name="singleButtonPressAction"></param>
        /// <param name="doubleButtonPressAction"></param>
        /// <param name="automaticBatteryTypeDetection"></param>
        /// <param name="unlatchDuration"></param>
        /// <param name="operationId"></param>
        /// <param name="totalDegrees"></param>
        /// <param name="singleLockedPositionOffsetDegrees"></param>
        /// <param name="unlockedToLockedTransitionOffsetDegrees"></param>
        /// <param name="unlockedPositionOffsetDegrees"></param>
        /// <param name="lockedPositionOffsetDegrees"></param>
        /// <param name="detachedCylinder"></param>
        /// <param name="batteryType"></param>
        /// <param name="autoLock"></param>
        /// <param name="autoLockTimeout"></param>
        /// <param name="autoUpdateEnabled"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdvancedConfigAsync(
              int smartlockId,
              int lngTimeout = 5,
              int singleButtonPressAction = 0,
              int doubleButtonPressAction = 0,
              bool automaticBatteryTypeDetection = true,
              int unlatchDuration = 1,
              string operationId = "",
              int totalDegrees = 0,
              int singleLockedPositionOffsetDegrees = 0,
              int unlockedToLockedTransitionOffsetDegrees = 0,
              int unlockedPositionOffsetDegrees = 0,
              int lockedPositionOffsetDegrees = 0,
              bool detachedCylinder = true,
              int batteryType = 0,
              bool autoLock = true,
              int autoLockTimeout = 0,
              bool autoUpdateEnabled = true)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("lngTimeout", $"{lngTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleButtonPressAction", $"{singleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("doubleButtonPressAction", $"{doubleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{automaticBatteryTypeDetection}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlatchDuration", $"{unlatchDuration}"));
            allInputParams.Add(new KeyValuePair<string, string>("operationId", $"{operationId}"));
            allInputParams.Add(new KeyValuePair<string, string>("totalDegrees", $"{totalDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleLockedPositionOffsetDegrees", $"{singleLockedPositionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlockedToLockedTransitionOffsetDegrees", $"{unlockedToLockedTransitionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlockedPositionOffsetDegrees", $"{unlockedPositionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("lockedPositionOffsetDegrees", $"{lockedPositionOffsetDegrees}"));
            allInputParams.Add(new KeyValuePair<string, string>("detachedCylinder", $"{detachedCylinder}"));
            allInputParams.Add(new KeyValuePair<string, string>("batteryType", $"{batteryType}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoLock", $"{autoLock}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoLockTimeout", $"{autoLockTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoUpdateEnabled", $"{autoUpdateEnabled}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/advanced/config", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates an opener advanced config
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdvancedOpenerconfigAsync(Model.Smartlock smartlock)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("intercomId", $"{smartlock.OpenerAdvancedConfig.IntercomId}"),
              new KeyValuePair<string, string>("busModeSwitch", $"{smartlock.OpenerAdvancedConfig.BusModeSwitch}"),
              new KeyValuePair<string, string>("shortCircuitDuration", $"{smartlock.OpenerAdvancedConfig.ShortCircuitDuration}"),
              new KeyValuePair<string, string>("electricStrikeDelay", $"{smartlock.OpenerAdvancedConfig.ElectricStrikeDelay}"),
              new KeyValuePair<string, string>("randomElectricStrikeDelay", $"{smartlock.OpenerAdvancedConfig.RandomElectricStrikeDelay}"),
              new KeyValuePair<string, string>("electricStrikeDuration", $"{smartlock.OpenerAdvancedConfig.ElectricStrikeDuration}"),
              new KeyValuePair<string, string>("disableRtoAfterRing", $"{smartlock.OpenerAdvancedConfig.DisableRtoAfterRing}"),
              new KeyValuePair<string, string>("rtoTimeout", $"{smartlock.OpenerAdvancedConfig.RtoTimeout}"),
              new KeyValuePair<string, string>("doorbellSuppression", $"{smartlock.OpenerAdvancedConfig.DoorbellSuppression}"),
              new KeyValuePair<string, string>("doorbellSuppressionDuration", $"{smartlock.OpenerAdvancedConfig.DoorbellSuppressionDuration}"),
              new KeyValuePair<string, string>("soundRing", $"{smartlock.OpenerAdvancedConfig.SoundRing}"),
              new KeyValuePair<string, string>("soundOpen", $"{smartlock.OpenerAdvancedConfig.SoundOpen}"),
              new KeyValuePair<string, string>("soundRto", $"{smartlock.OpenerAdvancedConfig.SoundRto}"),
              new KeyValuePair<string, string>("soundCm", $"{smartlock.OpenerAdvancedConfig.SoundCm}"),
              new KeyValuePair<string, string>("soundConfirmation", $"{smartlock.OpenerAdvancedConfig.SoundConfirmation}"),
              new KeyValuePair<string, string>("soundLevel", $"{smartlock.OpenerAdvancedConfig.SoundLevel}"),
              new KeyValuePair<string, string>("singleButtonPressAction", $"{smartlock.OpenerAdvancedConfig.SingleButtonPressAction}"),
              new KeyValuePair<string, string>("doubleButtonPressAction", $"{smartlock.OpenerAdvancedConfig.DoubleButtonPressAction}"),
              new KeyValuePair<string, string>("batteryType", $"{smartlock.OpenerAdvancedConfig.BatteryType}"),
              new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{smartlock.OpenerAdvancedConfig.AutomaticBatteryTypeDetection}"),
              new KeyValuePair<string, string>("autoUpdateEnabled", $"{smartlock.OpenerAdvancedConfig.AutoUpdateEnabled}"),
              new KeyValuePair<string, string>("operationId", $"{smartlock.OpenerAdvancedConfig.OperationId}")
           };

            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/advanced/openerconfig", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates an opener advanced config
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="intercomId"></param>
        /// <param name="busModeSwitch"></param>
        /// <param name="shortCircuitDuration"></param>
        /// <param name="electricStrikeDelay"></param>
        /// <param name="randomElectricStrikeDelay"></param>
        /// <param name="electricStrikeDuration"></param>
        /// <param name="disableRtoAfterRing"></param>
        /// <param name="rtoTimeout"></param>
        /// <param name="doorbellSuppression"></param>
        /// <param name="doorbellSuppressionDuration"></param>
        /// <param name="soundRing"></param>
        /// <param name="soundOpen"></param>
        /// <param name="soundRto"></param>
        /// <param name="soundCm"></param>
        /// <param name="soundConfirmation"></param>
        /// <param name="soundLevel"></param>
        /// <param name="singleButtonPressAction"></param>
        /// <param name="doubleButtonPressAction"></param>
        /// <param name="batteryType"></param>
        /// <param name="automaticBatteryTypeDetection"></param>
        /// <param name="autoUpdateEnabled"></param>
        /// <param name="operationId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdvancedOpenerconfigAsync(
            int smartlockId,
            int intercomId = 0,
            int busModeSwitch = 0,
            int shortCircuitDuration = 0,
            int electricStrikeDelay = 0,
            bool randomElectricStrikeDelay = true,
            int electricStrikeDuration = 0,
            bool disableRtoAfterRing = true,
            int rtoTimeout = 0,
            int doorbellSuppression = 0,
            int doorbellSuppressionDuration = 0,
            int soundRing = 0,
            int soundOpen = 0,
            int soundRto = 0,
            int soundCm = 0,
            int soundConfirmation = 0,
            int soundLevel = 0,
            int singleButtonPressAction = 0,
            int doubleButtonPressAction = 0,
            int batteryType = 0,
            bool automaticBatteryTypeDetection = true,
            bool autoUpdateEnabled = true,
            string operationId = "")
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("intercomId", $"{intercomId}"),
              new KeyValuePair<string, string>("busModeSwitch", $"{busModeSwitch}"),
              new KeyValuePair<string, string>("shortCircuitDuration", $"{shortCircuitDuration}"),
              new KeyValuePair<string, string>("electricStrikeDelay", $"{electricStrikeDelay}"),
              new KeyValuePair<string, string>("randomElectricStrikeDelay", $"{randomElectricStrikeDelay}"),
              new KeyValuePair<string, string>("electricStrikeDuration", $"{electricStrikeDuration}"),
              new KeyValuePair<string, string>("disableRtoAfterRing", $"{disableRtoAfterRing}"),
              new KeyValuePair<string, string>("rtoTimeout", $"{rtoTimeout}"),
              new KeyValuePair<string, string>("doorbellSuppression", $"{doorbellSuppression}"),
              new KeyValuePair<string, string>("doorbellSuppressionDuration", $"{doorbellSuppressionDuration}"),
              new KeyValuePair<string, string>("soundRing", $"{soundRing}"),
              new KeyValuePair<string, string>("soundOpen", $"{soundOpen}"),
              new KeyValuePair<string, string>("soundRto", $"{soundRto}"),
              new KeyValuePair<string, string>("soundCm", $"{soundCm}"),
              new KeyValuePair<string, string>("soundConfirmation", $"{soundConfirmation}"),
              new KeyValuePair<string, string>("soundLevel", $"{soundLevel}"),
              new KeyValuePair<string, string>("singleButtonPressAction", $"{singleButtonPressAction}"),
              new KeyValuePair<string, string>("doubleButtonPressAction", $"{doubleButtonPressAction}"),
              new KeyValuePair<string, string>("batteryType", $"{batteryType}"),
              new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{automaticBatteryTypeDetection}"),
              new KeyValuePair<string, string>("autoUpdateEnabled", $"{autoUpdateEnabled}"),
              new KeyValuePair<string, string>("operationId", $"{operationId}")
           };

            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/advanced/openerconfig", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates  a smartdoor advanced config
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdvancedSmartdoorconfigAsync(Model.Smartlock smartlock)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("lngTimeout", $"{smartlock.SmartdoorAdvancedConfig.LngTimeout}"),
              new KeyValuePair<string, string>("singleButtonPressAction", $"{smartlock.SmartdoorAdvancedConfig.SingleButtonPressAction}"),
              new KeyValuePair<string, string>("doubleButtonPressAction", $"{smartlock.SmartdoorAdvancedConfig.DoubleButtonPressAction}"),
              new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{smartlock.SmartdoorAdvancedConfig.AutomaticBatteryTypeDetection}"),
              new KeyValuePair<string, string>("unlatchDuration", $"{smartlock.SmartdoorAdvancedConfig.UnlatchDuration}"),
              new KeyValuePair<string, string>("operationId", $"{smartlock.SmartdoorAdvancedConfig.OperationId}"),
              new KeyValuePair<string, string>("buzzerVolume", $"{smartlock.SmartdoorAdvancedConfig.BuzzerVolume}"),
              new KeyValuePair<string, string>("supportedBatteryTypes", $"{smartlock.SmartdoorAdvancedConfig.SupportedBatteryTypes}"),
              new KeyValuePair<string, string>("batteryType", $"{smartlock.SmartdoorAdvancedConfig.BatteryType}"),
              new KeyValuePair<string, string>("autoLockTimeout", $"{smartlock.SmartdoorAdvancedConfig.AutoLockTimeout}"),
              new KeyValuePair<string, string>("autoLock", $"{smartlock.SmartdoorAdvancedConfig.AutoLock}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/advanced/smartdoorconfig", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates  a smartdoor advanced config
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="lngTimeout"></param>
        /// <param name="singleButtonPressAction"></param>
        /// <param name="doubleButtonPressAction"></param>
        /// <param name="automaticBatteryTypeDetection"></param>
        /// <param name="unlatchDuration"></param>
        /// <param name="operationId"></param>
        /// <param name="buzzerVolume"></param>
        /// <param name="supportedBatteryTypes"></param>
        /// <param name="batteryType"></param>
        /// <param name="autoLockTimeout"></param>
        /// <param name="autoLock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockAdvancedSmartdoorconfigAsync(
            int smartlockId,
            int lngTimeout = 5,
            int singleButtonPressAction = 0,
            int doubleButtonPressAction = 0,
            bool automaticBatteryTypeDetection = true,
            int unlatchDuration = 1,
            string operationId = "",
            int buzzerVolume = 0,
            IList<int> supportedBatteryTypes = null,
            int batteryType = 0,
            int autoLockTimeout = 0,
            bool autoLock = true)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("lngTimeout", $"{lngTimeout}"),
              new KeyValuePair<string, string>("singleButtonPressAction", $"{singleButtonPressAction}"),
              new KeyValuePair<string, string>("doubleButtonPressAction", $"{doubleButtonPressAction}"),
              new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{automaticBatteryTypeDetection}"),
              new KeyValuePair<string, string>("unlatchDuration", $"{unlatchDuration}"),
              new KeyValuePair<string, string>("operationId", $"{operationId}"),
              new KeyValuePair<string, string>("buzzerVolume", $"{buzzerVolume}"),
              new KeyValuePair<string, string>("supportedBatteryTypes",
                 $"{supportedBatteryTypes ?? new List<int>()}"),
              new KeyValuePair<string, string>("batteryType", $"{batteryType}"),
              new KeyValuePair<string, string>("autoLockTimeout", $"{autoLockTimeout}"),
              new KeyValuePair<string, string>("autoLock", $"{autoLock}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/advanced/smartdoorconfig", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock config
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockConfigAsync(Model.Smartlock smartlock)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("name", $"{smartlock.Config.Name}"),
              new KeyValuePair<string, string>("latitude", $"{smartlock.Config.Latitude}"),
              new KeyValuePair<string, string>("longitude", $"{smartlock.Config.Longitude}"),
              new KeyValuePair<string, string>("capabilities", $"{smartlock.Config.Capabilities}"),
              new KeyValuePair<string, string>("autoUnlatch", $"{smartlock.Config.AutoUnlatch}"),
              new KeyValuePair<string, string>("liftUpHandle", $"{smartlock.Config.LiftUpHandle}"),
              new KeyValuePair<string, string>("pairingEnabled", $"{smartlock.Config.PairingEnabled}"),
              new KeyValuePair<string, string>("buttonEnabled", $"{smartlock.Config.ButtonEnabled}"),
              new KeyValuePair<string, string>("ledEnabled", $"{smartlock.Config.LedEnabled}"),
              new KeyValuePair<string, string>("ledBrightness", $"{smartlock.Config.LedBrightness}"),
              new KeyValuePair<string, string>("timezoneOffset", $"{smartlock.Config.TimezoneOffset}"),
              new KeyValuePair<string, string>("daylightSavingMode", $"{smartlock.Config.DaylightSavingMode}"),
              new KeyValuePair<string, string>("fobPaired", $"{smartlock.Config.FobPaired}"),
              new KeyValuePair<string, string>("fobAction1", $"{smartlock.Config.FobAction1}"),
              new KeyValuePair<string, string>("fobAction2", $"{smartlock.Config.FobAction2}"),
              new KeyValuePair<string, string>("fobAction3", $"{smartlock.Config.FobAction3}"),
              new KeyValuePair<string, string>("singleLock", $"{smartlock.Config.SingleLock}"),
              new KeyValuePair<string, string>("operatingMode", $"{smartlock.Config.OperatingMode}"),
              new KeyValuePair<string, string>("advertisingMode", $"{smartlock.Config.AdvertisingMode}"),
              new KeyValuePair<string, string>("keypadPaired", $"{smartlock.Config.KeypadPaired}"),
              new KeyValuePair<string, string>("homekitState", $"{smartlock.Config.HomekitState}"),
              new KeyValuePair<string, string>("timezoneId", $"{smartlock.Config.TimezoneId}"),
              new KeyValuePair<string, string>("operationId", $"{smartlock.Config.OperationId}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/config", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock config
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="name"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <param name="capabilities"></param>
        /// <param name="autoUnlatch"></param>
        /// <param name="liftUpHandle"></param>
        /// <param name="pairingEnabled"></param>
        /// <param name="buttonEnabled"></param>
        /// <param name="ledEnabled"></param>
        /// <param name="ledBrightness"></param>
        /// <param name="timezoneOffset"></param>
        /// <param name="daylightSavingMode"></param>
        /// <param name="fobPaired"></param>
        /// <param name="fobAction1"></param>
        /// <param name="fobAction2"></param>
        /// <param name="fobAction3"></param>
        /// <param name="singleLock"></param>
        /// <param name="operatingMode"></param>
        /// <param name="advertisingMode"></param>
        /// <param name="keypadPaired"></param>
        /// <param name="homekitState"></param>
        /// <param name="timezoneId"></param>
        /// <param name="operationId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockConfigAsync(
            int smartlockId,
            string name = "",
            string latitude = "",
            string longitude = "",
            int capabilities = 0,
            bool autoUnlatch = true,
            bool liftUpHandle = true,
            bool pairingEnabled = true,
            bool buttonEnabled = true,
            bool ledEnabled = true,
            int ledBrightness = 0,
            int timezoneOffset = 0,
            int daylightSavingMode = 0,
            bool fobPaired = true,
            int fobAction1 = 0,
            int fobAction2 = 0,
            int fobAction3 = 0,
            bool singleLock = true,
            int operatingMode = 0,
            int advertisingMode = 0,
            bool keypadPaired = true,
            int homekitState = 0,
            int timezoneId = 0,
            string operationId = "")
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("name", $"{name}"),
              new KeyValuePair<string, string>("latitude", $"{latitude}"),
              new KeyValuePair<string, string>("longitude", $"{longitude}"),
              new KeyValuePair<string, string>("capabilities", $"{capabilities}"),
              new KeyValuePair<string, string>("autoUnlatch", $"{autoUnlatch}"),
              new KeyValuePair<string, string>("liftUpHandle", $"{liftUpHandle}"),
              new KeyValuePair<string, string>("pairingEnabled", $"{pairingEnabled}"),
              new KeyValuePair<string, string>("buttonEnabled", $"{buttonEnabled}"),
              new KeyValuePair<string, string>("ledEnabled", $"{ledEnabled}"),
              new KeyValuePair<string, string>("ledBrightness", $"{ledBrightness}"),
              new KeyValuePair<string, string>("timezoneOffset", $"{timezoneOffset}"),
              new KeyValuePair<string, string>("daylightSavingMode", $"{daylightSavingMode}"),
              new KeyValuePair<string, string>("fobPaired", $"{fobPaired}"),
              new KeyValuePair<string, string>("fobAction1", $"{fobAction1}"),
              new KeyValuePair<string, string>("fobAction2", $"{fobAction2}"),
              new KeyValuePair<string, string>("fobAction3", $"{fobAction3}"),
              new KeyValuePair<string, string>("singleLock", $"{singleLock}"),
              new KeyValuePair<string, string>("operatingMode", $"{operatingMode}"),
              new KeyValuePair<string, string>("advertisingMode", $"{advertisingMode}"),
              new KeyValuePair<string, string>("keypadPaired", $"{keypadPaired}"),
              new KeyValuePair<string, string>("homekitState", $"{homekitState}"),
              new KeyValuePair<string, string>("timezoneId", $"{timezoneId}"),
              new KeyValuePair<string, string>("operationId", $"{operationId}")
           };
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/config", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Syncs a smartlock
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockSyncAsync(Model.Smartlock smartlock)
        {
            var requestParams = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/sync", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Syncs a smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockSyncAsync(int smartlockId)
        {
            var requestParams = new FormUrlEncodedContent(new List<KeyValuePair<string, string>>());

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/sync", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock web config
        /// </summary>
        /// <param name="smartlock"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockWebConfigAsync(Model.Smartlock smartlock)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("batteryWarningPerMailEnabled", $"{smartlock.WebConfig.BatteryWarningPerMailEnabled}"),
              new KeyValuePair<string, string>("dismissedLiftUpHandleWarning", $"{smartlock.WebConfig.DismissedLiftUpHandleWarnings}")
           };

            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlock.SmartlockId}/web/config", requestParams);
                return response.StatusCode;
            }
        }

        /// <summary>
        /// Updates a smartlock web config
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <param name="batteryWarningPerMailEnabled"></param>
        /// <param name="dismissedLiftUpHandleWarning"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> PostSmartlockWebConfigAsync(
            int smartlockId,
            bool batteryWarningPerMailEnabled = true,
            IList<int> dismissedLiftUpHandleWarning = null)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>
           {
              new KeyValuePair<string, string>("batteryWarningPerMailEnabled", $"{batteryWarningPerMailEnabled}"),
              new KeyValuePair<string, string>("dismissedLiftUpHandleWarning", $"{dismissedLiftUpHandleWarning ?? new List<int>()}")
           };

            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (WebAPI.Client)
            {
                var response = await WebAPI.Client.PostAsync($"smartlock/{smartlockId}/web/config", requestParams);
                return response.StatusCode;
            }
        }
    }
}
