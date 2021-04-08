namespace Mapbox.Unity.Map
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using Mapbox.Unity.Utilities;
	using Utils;
	using UnityEngine;
	using Mapbox.Map;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.MeshGeneration.Data;
	using System.Globalization;
	using Mapbox.Unity.Location;
	using UnityEngine;

	public class InitializeMapWithLocationProvider : MonoBehaviour
	{
		public Vector2d _centerLatitudeLongitude;
		[SerializeField]
		AbstractMap _map;

		ILocationProvider _locationProvider;

		private void Awake()
		{
			// Prevent double initialization of the map. 
			_map.InitializeOnStart = true;
		}

		protected virtual IEnumerator Start()
		{
			yield return null;
			_locationProvider = LocationProviderFactory.Instance.DefaultLocationProvider;
			_locationProvider.OnLocationUpdated += LocationProvider_OnLocationUpdated; ;
		}
		
		void LocationProvider_OnLocationUpdated(Unity.Location.Location location)
		{
			_locationProvider.OnLocationUpdated -= LocationProvider_OnLocationUpdated;
			_map.Initialize(_centerLatitudeLongitude, _map.AbsoluteZoom);
		}
	}
}
