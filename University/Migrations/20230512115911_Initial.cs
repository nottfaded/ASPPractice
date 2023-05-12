using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "name", "description" },
                values: new object[] { 1, "Монітори", "Пристрій оперативного візуального зв'язку користувача з керуючим пристроєм та відображенням даних, що передаються з клавіатури, миші або центрального процесора" });
            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "id", "name", "description" },
               values: new object[] { 2, "Перифірія для ПК", "Апаратура, яка дозволяє вводити інформацію до комп'ютера або виводити її з нього" });
            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "id", "name", "description" },
               values: new object[] { 3, "Відеокарти", "Електронний пристрій, частина комп'ютера, призначена для генерації та обробки зображень з подальшим їхнім виведенням на екран периферійного пристрою." });
            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "id", "name", "description" },
               values: new object[] { 4, "Процесори", "Електронна схема, призначена для обробки даних (наприклад, виконання арифметичних і логічних операцій над даними, здійснення введення та виведення даних тощо)." });
            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "id", "name", "description" },
               values: new object[] { 5, "SSD-диски", "Комп'ютерний запам'ятовувальний пристрій на основі мікросхем пам'яті та контролера керування ними, що не містить рухомих механічних частин." });
            migrationBuilder.InsertData(
               table: "Categories",
               columns: new[] { "id", "name", "description" },
               values: new object[] { 6, "Блоки живлення", "Вторинне джерело живлення, призначене для забезпечення живлення електроприладу електричною енергією, при відповідності вимогам її параметрів: напруги, струму, і т. д. шляхом перетворення енергії інших джерел живлення" });



            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    countInStock = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    imageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 1, "Mонітор Gigabyte 23.8\" G24F Gaming Black", "Діагональ: 23.8\"\r\nРоздільна здатність: 1920x1080\r\nТип матриці: SS-IPS\r\nЧастота оновлення: 165 Гц\r\nЧас відгуку: 1 мс\r\nЯскравість: 300 кд/м?\r\nСпіввідношення сторін: 16:9", 10, 7999, 1, "/img/gigabyte-238-g24f-gaming-black.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 2, "Миша Logitech G102 Lightsync", "Призначення: Для геймінгу\r\nПідключення: Дротове\r\nІнтерфейс підключення: USB\r\nЧутливість: 200–8000 dpi\r\nТип мишки: Оптична (світлодіодна)\r\nКількість кнопок: 6 кнопок\r\nЖивлення: Від порту USB", 15, 999, 2, "/img/logitech-g102-lightsync-910-005823-black.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 3, "Asus 27\" TUF Gaming VG27AQA1A", "Діагональ: 27\"\r\nРоздільна здатність: 2560x1440\r\nТип матриці: VA\r\nЧастота оновлення: 170 Гц\r\nЧас відгуку: 1 мс\r\nЯскравість: 300 кд/м?\r\nДіагональ: 27\"\r\nРоздільна здатність: 2560x1440\r\nТип матриці: VA\r\nЧастота оновлення: 170 Гц\r\nЧас відгуку: 1 мс\r\nЯскравість: 300 кд/м?\r\nСпіввідношення сторін: 16:9", 12, 10999, 1, "/img/asus-27-tuf-gaming-vg27aqa1a-90lm05z0-b05370-black.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 4, "Samsung 28\" Odyssey G7 S28AG700NI", "Діагональ: 28\"\r\nРоздільна здатність: 3840x2160\r\nТип матриці: IPS\r\nЧастота оновлення: 144 Гц\r\nЧас відгуку: 1 мс\r\nЯскравість: 400 кд/м?\r\nСпіввідношення сторін: 16:9", 25, 20999, 1, "/img/samsung-28-odyssey-g7-s28ag700ni-ls28ag700nixci-black.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 5, "Samsung 27\" Curved", "Діагональ: 27\"\r\nРоздільна здатність: 1920x1080\r\nТип матриці: VA\r\nЧастота оновлення: 60 Гц\r\nЧас відгуку: 4 мс\r\nЯскравість: 250 кд/м?\r\nСпіввідношення сторін: 16:9", 5, 5999, 1, "/img/samsung-27-c27f390f-lc27f390fhixci-black.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 6, "Palit GeForce RTX 3060 Ti Dual V1 LHR", "Обсяг пам'яті: 8192 Мб\r\nТип пам'яті: GDDR6\r\nШина пам'яті: 256 бит\r\nЧастота графічного ядра : Boost: 1665 МГц\r\nЧастота відеопам'яті: 14000 МГц\r\nРоз'єми для монітора: 1 x HDMI 2.1\r\n3 x DisplayPort 1.4a\r\nПродуктивність: 20638", 10, 13999, 3, "/img/palit-geforce-rtx-3060-ti-dual-v1-lhr-8192mb-ne6306t019p2-190ad-fr-factory-recertified.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 7, "MSI GeForce RTX 3060 VENTUS 2X OC", "Обсяг пам'яті: 8192 Мб\r\nТип пам'яті: GDDR6\r\nШина пам'яті: 128 бит\r\nЧастота графічного ядра : Boost: 1807 МГц\r\nЧастота відеопам'яті: 15000 МГц\r\nРоз'єми для монітора: 1 x HDMI 2.1\r\n3 x DisplayPort 1.4a\r\nПродуктивність: 17207\r\nАпаратна особливість: Без обмеження", 50, 14699, 3, "/img/msi-geforce-rtx-3060-ventus-2x-oc-8192mb-rtx-3060-ventus-2x-8g-oc.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 8, "Asus TUF GeForce RTX 3060 Gaming OC", "Обсяг пам'яті: 12288 Мб\r\nТип пам'яті: GDDR6\r\nШина пам'яті: 192 бит\r\nЧастота графічного ядра : Boost: 1882 МГц\r\nЧастота відеопам'яті: 15000 МГц\r\nРоз'єми для монітора: 2 x HDMI 2.1\r\n3 x DisplayPort 1.4a\r\nПродуктивність: 17207\r\nАпаратна особливість: З обмеженням", 20, 18299, 3, "/img/asus-tuf-geforce-rtx-3060-gaming-oc-12288mb-tuf-rtx3060-o12g-v2-gaming.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 9, "Asus Dual Radeon RX 6750 XT OC", "Обсяг пам'яті: 12288 Мб\r\nТип пам'яті: GDDR6\r\nШина пам'яті: 192 бит\r\nЧастота графічного ядра : Boost: 2618 МГц\r\nЧастота відеопам'яті: 18000 МГц\r\nРоз'єми для монітора: 3 x DisplayPort 1.4\r\n1 x HDMI 2.1\r\nПродуктивність: 21590\r\nАпаратна особливість: Без обмеження", 15, 13299, 3, "/img/asus-dual-radeon-rx-6750-xt-oc-12288mb-dual-rx6750xt-o12g-fr-factory-recertified.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 10, "AMD Ryzen 7 7700 3.8(5.3)GHz", "Лінійка: AMD Ryzen 7\r\nРоз'єм процесора (Socket): AM5\r\nКількість ядер: 8 ядер\r\nІнтегрована графіка: Radeon Graphics\r\nСумісність: Материнские платы Socket AM5", 30, 13999, 4, "/img/amd-ryzen-7-7700-3853ghz-32mb-sam5-box-100-100000592box.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 11, "Intel Core i9-12900KS 3.4(5.5)GHz", "Лінійка: Intel Core i9\r\nРоз'єм процесора (Socket): LGA1700\r\nКількість ядер: 16 ядер\r\nІнтегрована графіка: Intel UHD Graphics 770\r\nСумісність: Материнські плати LGA1700", 45, 21999, 4, "/img/intel-core-i9-12900ks-3455ghz-30mb-s1700-box-bx8071512900ks.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 12, "Intel Core i7-13700K 3.4(5.4)GHz", "Лінійка: Intel Core i7\r\nРоз'єм процесора (Socket): LGA1700\r\nКількість ядер: 16 ядер\r\nІнтегрована графіка: Intel UHD Graphics 770\r\nСумісність: Материнські плати LGA1700", 30, 18599, 4, "/img/intel-core-i7-13700k-4254ghz-30mb-s1700-box-bx8071513700k.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 13, "Intel Core i5-11400 2.6(4.4)GHz", "Лінійка: Intel Core i5\r\nРоз'єм процесора (Socket): LGA1200\r\nКількість ядер: 6 ядер\r\nІнтегрована графіка: Intel UHD Graphics 730\r\nСумісність: Материнські плати LGA1200", 15, 5679, 4, "/img/intel-core-i5-11400-26ghz-12mb-s1200-tray-cm8070804497015.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 14, "SSD-диск Kingston NV2 3D", "Обсяг пам'яті: 1 ТБ\r\nФорм-фактор: M.2 2280\r\nТип осередків пам'яті: 3D-NAND\r\nІнтерфейс: PCIe 4.0 x4\r\nШвидкість читання: 3500 МБ/с\r\nШвидкість запису: 2100 МБ/с", 20, 2329, 5, "/img/kingston-nv2-3d-nand-1tb-m2-2280-pci-e-nvme-x4-snv2s1000g.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 15, "SSD-диск Kingston SSDNow A400 TLC 480GB 2.5''", "Обсяг пам'яті: 480 ГБ\r\nФорм-фактор: 2.5\"\r\nТип осередків пам'яті: 3D-NAND TLC\r\nІнтерфейс: SATA III\r\nШвидкість читання: 500 МБ/с\r\nШвидкість запису: 450 МБ/с", 15, 1189, 5, "/img/kingston-ssdnow-a400-tlc-480gb-25-sa400s37480g.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 16, "SSD-диск Samsung 980 V-NAND MLC 1TB M.2", "Обсяг пам'яті: 1 ТБ\r\nФорм-фактор: M.2 2280\r\nТип осередків пам'яті: V-NAND MLC\r\nІнтерфейс: PCIe 3.0 x4\r\nКонтролер: Samsung Pablo Controller\r\nШвидкість читання: 3500 МБ/с\r\nШвидкість запису: 3000 МБ/с", 30, 3019, 5, "/img/samsung-980-v-nand-mlc-1tb-m2-2280-pci-e-nvme-14-mz-v8v1t0bw.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 17, "CHIEFTEC Proton 600W", "Потужність: 600 Вт\r\nФорм-фактор: ATX\r\nСертифікат : Bronze\r\nПідключення до відеокарт: 6+2-pin 2 шт.", 40, 2699, 6, "/img/chieftec-proton-600w-bdf-600s.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 18, "MSI MEG 1300W", "Потужність: 1300 Вт\r\nФорм-фактор: ATX\r\nСертифікат : Platinum\r\nПідключення до відеокарт: 6+2-pin 8 шт., 16-pin 1 шт.", 30, 16999, 6, "/img/msi-meg-1300w-pcie5-ai1300p.png" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 19, "Be Quiet! System Power 10 850W", "Потужність: 850 Вт\r\nФорм-фактор: ATX\r\nСертифікат : Gold\r\nПідключення до відеокарт: 6+2-pin 4 шт.", 40, 4749, 6, "/img/be-quiet-system-power-10-850w-bn330.jpg" });
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "name", "description", "countInStock", "price", "categoryId", "imageUrl" },
                values: new object[] { 20, "Cooler Master MWE Gold V2 ATX 3.0 1250W", "Потужність: 1250 Вт\r\nФорм-фактор: ATX\r\nСертифікат : Gold\r\nПідключення до відеокарт: 6+2-pin 3 шт., 16-pin 1 шт.", 30, 9899, 6, "/img/cooler-master-mwe-gold-v2-1250w-mpe-c501-afcag-3.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
