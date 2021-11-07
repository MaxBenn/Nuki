﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nuki.WebAPI
{
    public static class Smartlock
    {

        /// <summary>
        /// Get a list of Smartlocks
        /// </summary>
        /// <returns></returns>
        public static async Task<Models.Smartlock.Smartlock[]> GetSmartlocksAsync()
        {
            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.GetAsync($"smartlock");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.Smartlock.Smartlock[]>(responseString);
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
        public static async Task<Models.Smartlock.Smartlock> PutSmartlockAsync(int smartlockId, int type, string name, string authUuid, int authId, string authSecret, int lmType)
        {
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("smartlockId", $"{smartlockId}"));
            allInputParams.Add(new KeyValuePair<string, string>("type", $"{type}"));
            allInputParams.Add(new KeyValuePair<string, string>("name", $"{name}"));
            allInputParams.Add(new KeyValuePair<string, string>("authUuid", $"{authUuid}"));
            allInputParams.Add(new KeyValuePair<string, string>("authId", $"{authId}"));
            allInputParams.Add(new KeyValuePair<string, string>("authSecret", $"{authSecret}"));
            allInputParams.Add(new KeyValuePair<string, string>("lmType", $"{lmType}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PutAsync($"smartlock", requestParams);
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.Smartlock.Smartlock>(responseString);
            }
        }
        /// <summary>
        /// Delete a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<HttpStatusCode> DeleteSmartlockAsync(int smartlockId)
        {
            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.DeleteAsync($"smartlock/{smartlockId}");
                return response.StatusCode;
            }
        }
        /// <summary>
        /// Get a Smartlock
        /// </summary>
        /// <param name="smartlockId"></param>
        /// <returns></returns>
        public static async Task<Models.Smartlock.Smartlock> GetSmartlockAsync(int smartlockId)
        {
            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.GetAsync($"smartlock/{smartlockId}");
                var responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Models.Smartlock.Smartlock>(responseString);
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

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("action", $"{action}"));
            allInputParams.Add(new KeyValuePair<string, string>("option", $"{option}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/action", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/action/lock", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/action/unlock", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("adminPin", $"{adminPin}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/admin/pin", requestParams);
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

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/advanced/config", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("intercomId", $"{intercomId}"));
            allInputParams.Add(new KeyValuePair<string, string>("busModeSwitch", $"{busModeSwitch}"));
            allInputParams.Add(new KeyValuePair<string, string>("shortCircuitDuration", $"{shortCircuitDuration}"));
            allInputParams.Add(new KeyValuePair<string, string>("electricStrikeDelay", $"{electricStrikeDelay}"));
            allInputParams.Add(new KeyValuePair<string, string>("randomElectricStrikeDelay", $"{randomElectricStrikeDelay}"));
            allInputParams.Add(new KeyValuePair<string, string>("electricStrikeDuration", $"{electricStrikeDuration}"));
            allInputParams.Add(new KeyValuePair<string, string>("disableRtoAfterRing", $"{disableRtoAfterRing}"));
            allInputParams.Add(new KeyValuePair<string, string>("rtoTimeout", $"{rtoTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("doorbellSuppression", $"{doorbellSuppression}"));
            allInputParams.Add(new KeyValuePair<string, string>("doorbellSuppressionDuration", $"{doorbellSuppressionDuration}"));
            allInputParams.Add(new KeyValuePair<string, string>("soundRing", $"{soundRing}"));
            allInputParams.Add(new KeyValuePair<string, string>("soundOpen", $"{soundOpen}"));
            allInputParams.Add(new KeyValuePair<string, string>("soundRto", $"{soundRto}"));
            allInputParams.Add(new KeyValuePair<string, string>("soundCm", $"{soundCm}"));
            allInputParams.Add(new KeyValuePair<string, string>("soundConfirmation", $"{soundConfirmation}"));
            allInputParams.Add(new KeyValuePair<string, string>("soundLevel", $"{soundLevel}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleButtonPressAction", $"{singleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("doubleButtonPressAction", $"{doubleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("batteryType", $"{batteryType}"));
            allInputParams.Add(new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{automaticBatteryTypeDetection}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoUpdateEnabled", $"{autoUpdateEnabled}"));
            allInputParams.Add(new KeyValuePair<string, string>("operationId", $"{operationId}"));

            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/advanced/openerconfig", requestParams);
                return response.StatusCode;
            }
        }

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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("lngTimeout", $"{lngTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleButtonPressAction", $"{singleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("doubleButtonPressAction", $"{doubleButtonPressAction}"));
            allInputParams.Add(new KeyValuePair<string, string>("automaticBatteryTypeDetection", $"{automaticBatteryTypeDetection}"));
            allInputParams.Add(new KeyValuePair<string, string>("unlatchDuration", $"{unlatchDuration}"));
            allInputParams.Add(new KeyValuePair<string, string>("operationId", $"{operationId}"));
            allInputParams.Add(new KeyValuePair<string, string>("buzzerVolume", $"{buzzerVolume}"));
            allInputParams.Add(new KeyValuePair<string, string>("supportedBatteryTypes", $"{supportedBatteryTypes ?? new List<int>()}"));
            allInputParams.Add(new KeyValuePair<string, string>("batteryType", $"{batteryType}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoLockTimeout", $"{autoLockTimeout}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoLock", $"{autoLock}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/advanced/smartdoorconfig", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("name", $"{name}"));
            allInputParams.Add(new KeyValuePair<string, string>("latitude", $"{latitude}"));
            allInputParams.Add(new KeyValuePair<string, string>("longitude", $"{longitude}"));
            allInputParams.Add(new KeyValuePair<string, string>("capabilities", $"{capabilities}"));
            allInputParams.Add(new KeyValuePair<string, string>("autoUnlatch", $"{autoUnlatch}"));
            allInputParams.Add(new KeyValuePair<string, string>("liftUpHandle", $"{liftUpHandle}"));
            allInputParams.Add(new KeyValuePair<string, string>("pairingEnabled", $"{pairingEnabled}"));
            allInputParams.Add(new KeyValuePair<string, string>("buttonEnabled", $"{buttonEnabled}"));
            allInputParams.Add(new KeyValuePair<string, string>("ledEnabled", $"{ledEnabled}"));
            allInputParams.Add(new KeyValuePair<string, string>("ledBrightness", $"{ledBrightness}"));
            allInputParams.Add(new KeyValuePair<string, string>("timezoneOffset", $"{timezoneOffset}"));
            allInputParams.Add(new KeyValuePair<string, string>("daylightSavingMode", $"{daylightSavingMode}"));
            allInputParams.Add(new KeyValuePair<string, string>("fobPaired", $"{fobPaired}"));
            allInputParams.Add(new KeyValuePair<string, string>("fobAction1", $"{fobAction1}"));
            allInputParams.Add(new KeyValuePair<string, string>("fobAction2", $"{fobAction2}"));
            allInputParams.Add(new KeyValuePair<string, string>("fobAction3", $"{fobAction3}"));
            allInputParams.Add(new KeyValuePair<string, string>("singleLock", $"{singleLock}"));
            allInputParams.Add(new KeyValuePair<string, string>("operatingMode", $"{operatingMode}"));
            allInputParams.Add(new KeyValuePair<string, string>("advertisingMode", $"{advertisingMode}"));
            allInputParams.Add(new KeyValuePair<string, string>("keypadPaired", $"{keypadPaired}"));
            allInputParams.Add(new KeyValuePair<string, string>("homekitState", $"{homekitState}"));
            allInputParams.Add(new KeyValuePair<string, string>("timezoneId", $"{timezoneId}"));
            allInputParams.Add(new KeyValuePair<string, string>("operationId", $"{operationId}"));
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/config", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/sync", requestParams);
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
            List<KeyValuePair<string, string>> allInputParams = new List<KeyValuePair<string, string>>();
            allInputParams.Add(new KeyValuePair<string, string>("batteryWarningPerMailEnabled", $"{batteryWarningPerMailEnabled}"));
            allInputParams.Add(new KeyValuePair<string, string>("dismissedLiftUpHandleWarning", $"{dismissedLiftUpHandleWarning ?? new List<int>()}"));

            var requestParams = new FormUrlEncodedContent(allInputParams);

            using (NukiApi.Client)
            {
                var response = await NukiApi.Client.PostAsync($"smartlock/{smartlockId}/web/config", requestParams);
                return response.StatusCode;
            }
        }
    }
}