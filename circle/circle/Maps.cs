﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yandex;

namespace circle
{
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту 
            ///с помощью правой кнопки мыши. 
            gMapControl1.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется 
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 18;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 2;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType =
                GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = true;

            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться 
            //18ти кратное приближение.
            gMapControl1.Zoom = 5;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются 
            //соответствующим образом.
            gMapControl1.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Google.
            gMapControl1.MapProvider =
            GMap.NET.MapProviders.GMapProviders.GoogleMap;
            GMap.NET.GMaps.Instance.Mode =
                GMap.NET.AccessMode.ServerOnly;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMap.NET.MapProviders.GMapProvider.WebProxy =
                System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
                System.Net.CredentialCache.DefaultCredentials;
            // Создаем новый список маркеров, с указанием компонента
            //в котором они будут использоваться и названием списка
            GMap.NET.WindowsForms.GMapOverlay markersOverlay =
                new GMap.NET.WindowsForms.GMapOverlay(gMapControl1, "marker");
            int scetchik = 1;
            for (int i = 0; i < genetic.fmap.Length; i++)
            {

                GeoPoint an = new GeoPoint();
                an = MarkerF.Coord(C.g[genetic.fmap[i]]);
                {
                    //Инициализация нового ЗЕЛЕНОГО маркера, с указанием его координат
                    GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen marker =
                        new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(
                        new GMap.NET.PointLatLng(an.Lat,an.Long));
                    marker.ToolTip =
                        new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(marker);
                    //Текст отображаемый при наведении на маркер
                    marker.ToolTipText = scetchik.ToString();
                    //Добавляем маркер в список маркеров
                    markersOverlay.Markers.Add(marker);
                    //Добавляем в компонент, список маркеров 
                    gMapControl1.Overlays.Add(markersOverlay);
                }
                scetchik++;
            }
            GeoPoint startmarker = new GeoPoint();
            startmarker = MarkerF.Coord(C.start);
            GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed markerR =
                        new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(
                        new GMap.NET.PointLatLng(startmarker.Lat, startmarker.Long));
            markerR.ToolTip =
                new GMap.NET.WindowsForms.ToolTips.GMapRoundedToolTip(markerR);
            //Текст отображаемый при наведении на маркер
            markerR.ToolTipText = "Start";
            //Добавляем маркер в список маркеров
            markersOverlay.Markers.Add(markerR);
            //Добавляем в компонент, список маркеров 
            gMapControl1.Overlays.Add(markersOverlay);
        }
    }
}
