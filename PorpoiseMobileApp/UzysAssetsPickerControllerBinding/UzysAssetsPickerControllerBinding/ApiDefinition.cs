using System;
using AssetsLibrary;
using CoreLocation;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace UzysAssetsPickerController
{
	// typedef void (^intBlock)(NSInteger);
	delegate void intBlock(nint arg0);

	// typedef void (^voidBlock)();
	delegate void voidBlock();

	// @interface UzysAppearanceConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface UzysAppearanceConfig
	{
		// @property (nonatomic, strong) NSString * assetSelectedImageName;
		[Export("assetSelectedImageName", ArgumentSemantic.Strong)]
		string AssetSelectedImageName { get; set; }

		// @property (nonatomic, strong) NSString * assetDeselectedImageName;
		[Export("assetDeselectedImageName", ArgumentSemantic.Strong)]
		string AssetDeselectedImageName { get; set; }

		// @property (nonatomic, strong) NSString * assetsGroupSelectedImageName;
		[Export("assetsGroupSelectedImageName", ArgumentSemantic.Strong)]
		string AssetsGroupSelectedImageName { get; set; }

		// @property (nonatomic, strong) NSString * cameraImageName;
		[Export("cameraImageName", ArgumentSemantic.Strong)]
		string CameraImageName { get; set; }

		// @property (nonatomic, strong) NSString * closeImageName;
		[Export("closeImageName", ArgumentSemantic.Strong)]
		string CloseImageName { get; set; }

		// @property (nonatomic, strong) UIColor * finishSelectionButtonColor;
		[Export("finishSelectionButtonColor", ArgumentSemantic.Strong)]
		UIColor FinishSelectionButtonColor { get; set; }

		// @property (assign, nonatomic) NSInteger assetsCountInALine;
		[Export("assetsCountInALine")]
		nint AssetsCountInALine { get; set; }

		// @property (assign, nonatomic) CGFloat cellSpacing;
		[Export("cellSpacing")]
		nfloat CellSpacing { get; set; }

		// +(instancetype)sharedConfig;
		[Static]
		[Export("sharedConfig")]
		UzysAppearanceConfig SharedConfig();
	}

	// @interface UzysGroupPickerView : UIView <UITableViewDataSource, UITableViewDelegate, UIGestureRecognizerDelegate>
	[BaseType(typeof(UIView))]
	interface UzysGroupPickerView : IUITableViewDataSource, IUITableViewDelegate, IUIGestureRecognizerDelegate
	{
		// @property (nonatomic, strong) UITableView * tableView;
		[Export("tableView", ArgumentSemantic.Strong)]
		UITableView TableView { get; set; }

		// @property (strong) NSMutableArray * groups;
		[Export("groups", ArgumentSemantic.Strong)]
		NSMutableArray Groups { get; set; }

		// @property (nonatomic, strong) UITapGestureRecognizer * tapGestureRecognizer;
		[Export("tapGestureRecognizer", ArgumentSemantic.Strong)]
		UITapGestureRecognizer TapGestureRecognizer { get; set; }

		// @property (copy, nonatomic) intBlock blockTouchCell;
		[Export("blockTouchCell", ArgumentSemantic.Copy)]
		intBlock BlockTouchCell { get; set; }

		// @property (assign, nonatomic) BOOL isOpen;
		[Export("isOpen")]
		bool IsOpen { get; set; }

		// -(id)initWithGroups:(NSMutableArray *)groups;
		[Export("initWithGroups:")]
		IntPtr Constructor(NSMutableArray groups);

		// -(void)show;
		[Export("show")]
		void Show();

		// -(void)dismiss:(BOOL)animated;
		[Export("dismiss:")]
		void Dismiss(bool animated);

		// -(void)toggle;
		[Export("toggle")]
		void Toggle();

		// -(void)reloadData;
		[Export("reloadData")]
		void ReloadData();
	}

	// @protocol UzysAssetsPickerControllerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface UzysAssetsPickerControllerDelegate
	{
		// @required -(void)uzysAssetsPickerController:(UzysAssetsPickerController *)picker didFinishPickingAssets:(NSArray *)assets;
		[Abstract]
		[Export("uzysAssetsPickerController:didFinishPickingAssets:")]
		//[Verify(StronglyTypedNSArray)]
		void UzysAssetsPickerController(UzysAssetsPickerController picker, NSObject[] assets);

		// @optional -(void)uzysAssetsPickerControllerDidCancel:(UzysAssetsPickerController *)picker;
		[Export("uzysAssetsPickerControllerDidCancel:")]
		void UzysAssetsPickerControllerDidCancel(UzysAssetsPickerController picker);

		// @optional -(void)uzysAssetsPickerControllerDidExceedMaximumNumberOfSelection:(UzysAssetsPickerController *)picker;
		[Export("uzysAssetsPickerControllerDidExceedMaximumNumberOfSelection:")]
		void UzysAssetsPickerControllerDidExceedMaximumNumberOfSelection(UzysAssetsPickerController picker);
	}

	// @interface UzysAssetsPickerController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface UzysAssetsPickerController
	{
		// @property (nonatomic, strong) ALAssetsFilter * assetsFilter;
		[Export("assetsFilter", ArgumentSemantic.Strong)]
		ALAssetsFilter AssetsFilter { get; set; }

		// @property (nonatomic, strong) CLLocation * location;
		[Export("location", ArgumentSemantic.Strong)]
		CLLocation Location { get; set; }

		// @property (assign, nonatomic) NSInteger maximumNumberOfSelectionVideo;
		[Export("maximumNumberOfSelectionVideo")]
		nint MaximumNumberOfSelectionVideo { get; set; }

		// @property (assign, nonatomic) NSInteger maximumNumberOfSelectionPhoto;
		[Export("maximumNumberOfSelectionPhoto")]
		nint MaximumNumberOfSelectionPhoto { get; set; }

		// @property (nonatomic, strong) ALAsset * selectedAsset;
		[Export("selectedAsset", ArgumentSemantic.Strong)]
		ALAsset SelectedAsset { get; set; }

		// @property (assign, nonatomic) NSInteger maximumNumberOfSelectionMedia;
		[Export("maximumNumberOfSelectionMedia")]
		nint MaximumNumberOfSelectionMedia { get; set; }

		// @property (nonatomic, strong) UzysGroupPickerView * groupPicker;
		[Export("groupPicker", ArgumentSemantic.Strong)]
		UzysGroupPickerView GroupPicker { get; set; }

		// @property (nonatomic, strong) NSMutableArray * orderedSelectedItem;
		[Export("orderedSelectedItem", ArgumentSemantic.Strong)]
		NSMutableArray OrderedSelectedItem { get; set; }

		// @property (nonatomic, weak) UIButton * btnDone __attribute__((iboutlet));
		[Export("btnDone", ArgumentSemantic.Weak)]
		UIButton BtnDone { get; set; }

		[Wrap("WeakDelegate")]
		UzysAssetsPickerControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<UzysAssetsPickerControllerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// +(ALAssetsLibrary *)defaultAssetsLibrary;
		[Static]
		[Export("defaultAssetsLibrary")]
		//[Verify(MethodToProperty)]
		ALAssetsLibrary DefaultAssetsLibrary { get; }

		// +(void)setUpAppearanceConfig:(UzysAppearanceConfig *)config;
		[Static]
		[Export("setUpAppearanceConfig:")]
		void SetUpAppearanceConfig(UzysAppearanceConfig config);
	}
}
