namespace FHashtag

open System

open Foundation
open UIKit

[<Register ("PersonTvc")>]
type PersonTvc (handle:IntPtr) =
    inherit UITableViewController (handle)

    override x.NumberOfSections (tableView:UITableView) = 1


