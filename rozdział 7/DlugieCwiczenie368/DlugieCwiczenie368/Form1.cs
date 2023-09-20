namespace DlugieCwiczenie368
{
    public partial class Form1 : Form
    {
        int Moves;
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secoundBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }
        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Salon", "antyczny dywan", "w szafie œciennej", "dêbowe drzwi z mosiê¿n¹ klamk¹");
            diningRoom = new RoomWithHidingPlace("Jadalnia", "kryszta³owy ¿yrandol", "w wysokiej szafie");
            kitchen = new RoomWithDoor("Kuchnia", "nierdzewne stalowe sztuæce", "w szafce", "rozsuwane drzwi");
            stairs = new Room("Schody", "drewniana porêcz");
            hallway = new RoomWithHidingPlace("Korytarz na górze", "Obrazek z psem", "w szafie œciennej");
            bathroom = new RoomWithHidingPlace("£azienka", "umywalka i toaleta", "pod prysznicem");
            masterBedroom = new RoomWithHidingPlace("Du¿a sypialnia", "du¿e ³ó¿ko", "pod ³ó¿kiem");
            secoundBedroom = new RoomWithHidingPlace("Druga sypialnia", "ma³e ³ó¿ko", "pod ³ó¿kiem");
            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "ciêzkie dêbowe drzwi");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "rozsuwane drzwi");
            garden = new OutsideWithHidingPlace("Ogród", false, "w szopie");
            driveway = new OutsideWithHidingPlace("Droga dojazdowa", true, "w gara¿u");

            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secoundBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secoundBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }
        private void MoveToANewLocation(Location newlocation)
        {
            Moves++;
            currentLocation = newlocation;
            RedrawForm();
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Odnalaz³eœ mnie w " + Moves + " ruchach!");
                IHidingPlace foundlocation = currentLocation as IHidingPlace;
                description.Text = "Znalaz³eœ przeciwnika w " + Moves + " ruchah! Ukrywa³ siê " + foundlocation.HidingPlaceName + ".";
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
        }
        private void RedrawForm()
        {
            exits.Items.Clear();
            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(ruch numer " + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingplace = currentLocation as IHidingPlace;
                check.Text = "SprawdŸ " + hidingplace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Chceck(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;
            for(int i = 1; i <= 10; i++)
            {
                opponent.Move();
                description.Text = i + "... ";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            description.Text = "Gotowy czy nie - nadchodzê!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}