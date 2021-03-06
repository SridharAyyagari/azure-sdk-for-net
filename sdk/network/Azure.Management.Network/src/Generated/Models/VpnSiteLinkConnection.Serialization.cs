// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VpnSiteLinkConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (VpnSiteLink != null)
            {
                writer.WritePropertyName("vpnSiteLink");
                writer.WriteObjectValue(VpnSiteLink);
            }
            if (RoutingWeight != null)
            {
                writer.WritePropertyName("routingWeight");
                writer.WriteNumberValue(RoutingWeight.Value);
            }
            if (ConnectionStatus != null)
            {
                writer.WritePropertyName("connectionStatus");
                writer.WriteStringValue(ConnectionStatus.Value.ToString());
            }
            if (VpnConnectionProtocolType != null)
            {
                writer.WritePropertyName("vpnConnectionProtocolType");
                writer.WriteStringValue(VpnConnectionProtocolType.Value.ToString());
            }
            if (IngressBytesTransferred != null)
            {
                writer.WritePropertyName("ingressBytesTransferred");
                writer.WriteNumberValue(IngressBytesTransferred.Value);
            }
            if (EgressBytesTransferred != null)
            {
                writer.WritePropertyName("egressBytesTransferred");
                writer.WriteNumberValue(EgressBytesTransferred.Value);
            }
            if (ConnectionBandwidth != null)
            {
                writer.WritePropertyName("connectionBandwidth");
                writer.WriteNumberValue(ConnectionBandwidth.Value);
            }
            if (SharedKey != null)
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            if (EnableBgp != null)
            {
                writer.WritePropertyName("enableBgp");
                writer.WriteBooleanValue(EnableBgp.Value);
            }
            if (UsePolicyBasedTrafficSelectors != null)
            {
                writer.WritePropertyName("usePolicyBasedTrafficSelectors");
                writer.WriteBooleanValue(UsePolicyBasedTrafficSelectors.Value);
            }
            if (IpsecPolicies != null)
            {
                writer.WritePropertyName("ipsecPolicies");
                writer.WriteStartArray();
                foreach (var item in IpsecPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EnableRateLimiting != null)
            {
                writer.WritePropertyName("enableRateLimiting");
                writer.WriteBooleanValue(EnableRateLimiting.Value);
            }
            if (UseLocalAzureIpAddress != null)
            {
                writer.WritePropertyName("useLocalAzureIpAddress");
                writer.WriteBooleanValue(UseLocalAzureIpAddress.Value);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VpnSiteLinkConnection DeserializeVpnSiteLinkConnection(JsonElement element)
        {
            string name = default;
            string etag = default;
            string type = default;
            string id = default;
            SubResource vpnSiteLink = default;
            int? routingWeight = default;
            VpnConnectionStatus? connectionStatus = default;
            VirtualNetworkGatewayConnectionProtocol? vpnConnectionProtocolType = default;
            long? ingressBytesTransferred = default;
            long? egressBytesTransferred = default;
            int? connectionBandwidth = default;
            string sharedKey = default;
            bool? enableBgp = default;
            bool? usePolicyBasedTrafficSelectors = default;
            IList<IpsecPolicy> ipsecPolicies = default;
            bool? enableRateLimiting = default;
            bool? useLocalAzureIpAddress = default;
            ProvisioningState? provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vpnSiteLink"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnSiteLink = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("routingWeight"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            routingWeight = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("connectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionStatus = new VpnConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vpnConnectionProtocolType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vpnConnectionProtocolType = new VirtualNetworkGatewayConnectionProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("ingressBytesTransferred"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ingressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("egressBytesTransferred"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            egressBytesTransferred = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("connectionBandwidth"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionBandwidth = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sharedKey"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sharedKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enableBgp"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBgp = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("usePolicyBasedTrafficSelectors"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            usePolicyBasedTrafficSelectors = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ipsecPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IpsecPolicy> array = new List<IpsecPolicy>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(IpsecPolicy.DeserializeIpsecPolicy(item));
                                }
                            }
                            ipsecPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("enableRateLimiting"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableRateLimiting = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("useLocalAzureIpAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useLocalAzureIpAddress = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VpnSiteLinkConnection(id, name, etag, type, vpnSiteLink, routingWeight, connectionStatus, vpnConnectionProtocolType, ingressBytesTransferred, egressBytesTransferred, connectionBandwidth, sharedKey, enableBgp, usePolicyBasedTrafficSelectors, ipsecPolicies, enableRateLimiting, useLocalAzureIpAddress, provisioningState);
        }
    }
}
