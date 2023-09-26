namespace Wyprawa
{
    public partial class Form1 : Form
    {

        private Game game;
        private Random random = new Random();
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            timer1.Start();
        }

        public void UpdateCharacters()
        {
            PlayerPicture.Location = game.PlayerLocation;
            PlayerHP.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    BatPicture.Visible = true;
                    BatPicture.Location = enemy.Location;
                    BatHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    GhostPicture.Visible = true;
                    GhostPicture.Location = enemy.Location;
                    GhostHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    GhoulPicture.Visible = true;
                    GhoulPicture.Location = enemy.Location;
                    GhoulHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }
            if (!showBat)
            {
                BatPicture.Visible = false;
                BatHP.Text = "";
            }
            if (!showGhost)
            {
                GhostPicture.Visible = false;
                GhostHP.Text = "";
            }
            if (!showGhoul)
            {
                GhoulPicture.Visible = false;
                GhoulHP.Text = "";
            }
            SwordPicture.Visible = false;
            BowPicture.Visible = false;
            RedPotionPicture.Visible = false;
            BluePotionPicture.Visible = false;
            MacePicture.Visible = false;
            PictureBox weaponControl = null;


            switch (game.WeaponInRoom.Name)
            {
                case "Miecz":
                    weaponControl = SwordPicture; break;
                case "Luk":
                    weaponControl = BowPicture; break;
                case "Bulawa":
                    weaponControl = MacePicture; break;
                case "Czerwona mikstura":
                    weaponControl = RedPotionPicture; break;
                case "Niebieska mikstura":
                    weaponControl = BluePotionPicture; break;
            }
            if (weaponControl != null)
            {
                weaponControl.Visible = true;
                weaponControl.Location = game.WeaponInRoom.Location;
                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
                {
                    weaponControl.Visible = true;
                }
            }

            PictureBox weaponInventoryShow = null;
            foreach (string weapon in game.PlayerWeapons)
            {

                if (game.CheckPlayerInventory(weapon))
                {

                    switch (weapon)
                    {
                        case "Miecz":
                            weaponInventoryShow = SwordBox; break;
                        case "Luk":
                            weaponInventoryShow = BowBox; break;
                        case "Bulawa":
                            weaponInventoryShow = MaceBox; break;
                        case "Czerwona mikstura":
                            weaponInventoryShow = RedBox; break;
                        case "Niebieska mikstura":
                            weaponInventoryShow = BlueBox; break;
                    }
                    weaponInventoryShow.Visible = true;
                    if (game.WasPotionUsed(weapon))
                        weaponInventoryShow.Visible = false;
                    if (game.PlayerWeapons.Count() == 1)
                        weaponInventoryShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                }
            }
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("zostales zabity", "koniec gry");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("pokonales przeciwnikow na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }

        }

        private void SwordBox_Click(object sender, EventArgs e)
        {
            SwordBoxClick();
        }
        private void SwordBoxClick()
        {
            if (game.CheckPlayerInventory("Miecz"))
            {
                game.Equip("Miecz");
                SwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                BowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                MaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BlueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                RedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                AttackDown.Visible = true;
                AttackLeft.Visible = true;
                AttackRight.Visible = true;
                AttackUp.Text = "↑";
                AttackUp.Size = new System.Drawing.Size(25, 25);
            }
            else return;
        }

        private void BowBox_Click(object sender, EventArgs e)
        {
            BowBoxClick();
        }
        private void BowBoxClick()
        {
            if (game.CheckPlayerInventory("Luk"))
            {
                game.Equip("Luk");
                SwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BowBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                MaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BlueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                RedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                AttackDown.Visible = true;
                AttackLeft.Visible = true;
                AttackRight.Visible = true;
                AttackUp.Text = "↑";
                AttackUp.Size = new System.Drawing.Size(25, 25);
            }
            else return;
        }

        private void MaceBox_Click(object sender, EventArgs e)
        {
            MaceBoxClick();
        }
        private void MaceBoxClick()
        {
            if (game.CheckPlayerInventory("Bulawa"))
            {
                game.Equip("Bulawa");
                SwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                MaceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                BlueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                RedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                AttackDown.Visible = true;
                AttackLeft.Visible = true;
                AttackRight.Visible = true;
                AttackUp.Text = "↑";
                AttackUp.Size = new System.Drawing.Size(25, 25);
            }
            else return;
        }

        private void BlueBox_Click(object sender, EventArgs e)
        {
            BlueBoxClick();
        }
        private void BlueBoxClick()
        {
            if (game.CheckPlayerInventory("Niebieska mikstura"))
            {
                game.Equip("Niebieska mikstura");
                SwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                MaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BlueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                RedBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                AttackDown.Visible = false;
                AttackLeft.Visible = false;
                AttackRight.Visible = false;
                AttackUp.Text = "wypij";
            }
            else return;
        }

        private void RedBox_Click(object sender, EventArgs e)
        {
            RedBoxClick();
        }
        private void RedBoxClick()
        {
            if (game.CheckPlayerInventory("Czerwona mikstura"))
            {
                game.Equip("Czerwona mikstura");
                SwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                MaceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                BlueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                RedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                AttackDown.Visible = false;
                AttackLeft.Visible = false;
                AttackRight.Visible = false;
                AttackUp.Text = "wypij";
            }
            else return;
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void AttackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        game.Attack(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    case Keys.D:
                        game.Attack(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    case Keys.W:
                        game.Attack(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    case Keys.S:
                        game.Attack(Direction.Down, random);
                        UpdateCharacters();
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        game.Move(Direction.Left, random);
                        UpdateCharacters();
                        break;
                    case Keys.D:
                        game.Move(Direction.Right, random);
                        UpdateCharacters();
                        break;
                    case Keys.W:
                        game.Move(Direction.Up, random);
                        UpdateCharacters();
                        break;
                    case Keys.S:
                        game.Move(Direction.Down, random);
                        UpdateCharacters();
                        break;
                    case Keys.D1:
                        SwordBoxClick(); break;
                    case Keys.D2:
                        BowBoxClick(); break;
                    case Keys.D3:
                        MaceBoxClick(); break;
                    case Keys.D4:
                        BlueBoxClick(); break;
                    case Keys.D5:
                        RedBoxClick(); break;
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
