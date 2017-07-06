<?xml version="1.0" encoding="UTF-8" standalone="no"?>
<document type="com.apple.InterfaceBuilder3.CocoaTouch.Storyboard.XIB" version="3.0" toolsVersion="12118" systemVersion="16E195" targetRuntime="iOS.CocoaTouch" propertyAccessControl="none" useAutolayout="YES" useTraitCollections="YES" colorMatched="YES" initialViewController="Ou3-ga-60d">
    <device id="retina4_7" orientation="portrait">
        <adaptation id="fullscreen"/>
    </device>
    <dependencies>
        <plugIn identifier="com.apple.InterfaceBuilder.IBCocoaTouchPlugin" version="12086"/>
        <capability name="Alignment constraints with different attributes" minToolsVersion="5.1"/>
        <capability name="Aspect ratio constraints" minToolsVersion="5.1"/>
        <capability name="Constraints to layout margins" minToolsVersion="6.0"/>
        <capability name="Constraints with non-1.0 multipliers" minToolsVersion="5.1"/>
        <capability name="documents saved in the Xcode 8 format" minToolsVersion="8.0"/>
    </dependencies>
    <scenes>
        <!--Loading-->
        <scene sceneID="ihI-PI-Q9v">
            <objects>
                <viewController storyboardIdentifier="LoadingViewController" title="Loading" id="Ou3-ga-60d" customClass="LoadingViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="ofk-H4-Yod"/>
                        <viewControllerLayoutGuide type="bottom" id="Tx3-gV-AgU"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="7Et-WC-MFZ">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <activityIndicatorView opaque="NO" contentMode="scaleToFill" horizontalHuggingPriority="750" verticalHuggingPriority="750" misplaced="YES" style="whiteLarge" translatesAutoresizingMaskIntoConstraints="NO" id="Ifg-z5-Osv" userLabel="waiting indicator">
                                <rect key="frame" x="366" y="494" width="37" height="37"/>
                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                            </activityIndicatorView>
                        </subviews>
                        <constraints>
                            <constraint firstItem="Ifg-z5-Osv" firstAttribute="centerY" secondItem="7Et-WC-MFZ" secondAttribute="centerY" id="Cyf-dg-nJ5"/>
                            <constraint firstItem="Ifg-z5-Osv" firstAttribute="centerX" secondItem="7Et-WC-MFZ" secondAttribute="centerX" id="yiF-32-LWs"/>
                        </constraints>
                    </view>
                    <extendedEdge key="edgesForExtendedLayout"/>
                    <connections>
                        <outlet property="Waiting" destination="Ifg-z5-Osv" id="name-outlet-Ifg-z5-Osv"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="PhC-qp-rdM" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="-828" y="-54"/>
        </scene>
        <!--Title-->
        <scene sceneID="99">
            <objects>
                <viewController storyboardIdentifier="LoginViewController" hidesBottomBarWhenPushed="YES" id="100" customClass="LoginViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="97"/>
                        <viewControllerLayoutGuide type="bottom" id="98"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="154">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <subviews>
                            <imageView hidden="YES" contentMode="scaleAspectFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" translatesAutoresizingMaskIntoConstraints="NO" id="cRx-gJ-61v" misplaced="YES">
                                <rect key="frame" x="-4" y="0.0" width="334" height="667"/>
                                <constraints>
                                    <constraint firstAttribute="width" secondItem="cRx-gJ-61v" secondAttribute="height" multiplier="1:1" id="H0B-0X-Ea3"/>
                                    <constraint firstAttribute="width" secondItem="cRx-gJ-61v" secondAttribute="height" multiplier="1:2" id="Nc1-qL-GJ2"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="constraints">
                                        <exclude reference="H0B-0X-Ea3"/>
                                        <exclude reference="Nc1-qL-GJ2"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="constraints">
                                        <include reference="Nc1-qL-GJ2"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=regular">
                                    <mask key="constraints">
                                        <include reference="H0B-0X-Ea3"/>
                                    </mask>
                                </variation>
                            </imageView>
                            <view contentMode="scaleToFill" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="bAa-Di-Ylg" userLabel="FormContainer">
                                <rect key="frame" x="0.0" y="0.0" width="240" height="128"/>
                                <subviews>
                                    <imageView userInteractionEnabled="NO" contentMode="scaleAspectFit" horizontalHuggingPriority="251" verticalHuggingPriority="251" image="Logo_outline.png" translatesAutoresizingMaskIntoConstraints="NO" id="h2V-42-bDi">
                                        <rect key="frame" x="108" y="8" width="160" height="130"/>
                                        <gestureRecognizers/>
                                        <constraints>
                                            <constraint firstAttribute="height" constant="110" id="c26-18-jHA">
                                                <variation key="heightClass=regular-widthClass=compact" constant="130"/>
                                                <variation key="heightClass=regular-widthClass=regular" constant="130"/>
                                            </constraint>
                                            <constraint firstAttribute="width" constant="160" id="x7A-wL-KAc">
                                                <variation key="heightClass=regular-widthClass=compact" constant="160"/>
                                            </constraint>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="c26-18-jHA"/>
                                                <exclude reference="x7A-wL-KAc"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="c26-18-jHA"/>
                                                <include reference="x7A-wL-KAc"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="constraints">
                                                <include reference="c26-18-jHA"/>
                                                <include reference="x7A-wL-KAc"/>
                                            </mask>
                                        </variation>
                                    </imageView>
                                    <view contentMode="scaleToFill" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="int-s8-pcu" userLabel="LoginFieldsContainer">
                                        <rect key="frame" x="20" y="20" width="360" height="372"/>
                                        <subviews>
                                            <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" misplaced="YES" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="Email" textAlignment="natural" minimumFontSize="17" clearButtonMode="whileEditing" translatesAutoresizingMaskIntoConstraints="NO" id="ydh-g5-rav" customClass="PorpoiseEditText">
                                                <rect key="frame" x="-25" y="-30" width="97" height="30"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <accessibility key="accessibilityConfiguration" hint="Email field" identifier="Email" label="Email field"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="C8f-Fs-2b9"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits" autocorrectionType="no" keyboardType="emailAddress" returnKeyType="next"/>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="C8f-Fs-2b9"/>
                                                    </mask>
                                                </variation>
                                            </textField>
                                            <button opaque="NO" contentMode="scaleToFill" misplaced="YES" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="9cS-Sy-EuZ" customClass="PorpoiseButton">
                                                <rect key="frame" x="-23" y="-15" width="46" height="30"/>
                                                <accessibility key="accessibilityConfiguration" hint="Login" identifier="Login" label="Login"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="kcW-u3-wFr"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="19"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <state key="normal" title="Login">
                                                    <color key="titleColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                </state>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="kcW-u3-wFr"/>
                                                    </mask>
                                                </variation>
                                            </button>
                                            <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" misplaced="YES" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="Password" textAlignment="natural" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="IN3-zJ-IPm" customClass="PorpoiseEditText">
                                                <rect key="frame" x="-25" y="-30" width="97" height="30"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <accessibility key="accessibilityConfiguration" hint="Password Field" identifier="Password" label="Password Field"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="fm8-e8-UFF"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits" returnKeyType="done"/>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="fm8-e8-UFF"/>
                                                    </mask>
                                                </variation>
                                            </textField>
                                            <activityIndicatorView hidden="YES" opaque="NO" contentMode="scaleToFill" style="white" translatesAutoresizingMaskIntoConstraints="NO" id="340" misplaced="YES">
                                                <rect key="frame" x="215" y="81" width="20" height="20"/>
                                                <constraints>
                                                    <constraint firstAttribute="width" constant="20" id="343"/>
                                                    <constraint firstAttribute="height" constant="20" id="344"/>
                                                </constraints>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="343"/>
                                                        <include reference="344"/>
                                                    </mask>
                                                </variation>
                                            </activityIndicatorView>
                                        </subviews>
                                        <constraints>
                                            <constraint firstItem="9cS-Sy-EuZ" firstAttribute="top" secondItem="IN3-zJ-IPm" secondAttribute="bottom" constant="8" id="1Om-VK-M5F"/>
                                            <constraint firstItem="IN3-zJ-IPm" firstAttribute="leading" secondItem="int-s8-pcu" secondAttribute="leading" constant="8" id="2sg-eQ-dte">
                                                <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                            </constraint>
                                            <constraint firstAttribute="trailing" secondItem="340" secondAttribute="trailing" constant="100" id="A6U-nF-gq9"/>
                                            <constraint firstAttribute="trailing" secondItem="9cS-Sy-EuZ" secondAttribute="trailing" constant="8" id="EJ3-g8-zkR">
                                                <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                            </constraint>
                                            <constraint firstItem="340" firstAttribute="top" secondItem="9cS-Sy-EuZ" secondAttribute="bottom" constant="-25" id="Nho-cn-YWA"/>
                                            <constraint firstItem="9cS-Sy-EuZ" firstAttribute="leading" secondItem="int-s8-pcu" secondAttribute="leading" constant="8" id="Rjl-vA-h01">
                                                <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                            </constraint>
                                            <constraint firstItem="ydh-g5-rav" firstAttribute="top" secondItem="int-s8-pcu" secondAttribute="top" id="Vll-U9-EyK"/>
                                            <constraint firstItem="IN3-zJ-IPm" firstAttribute="top" secondItem="ydh-g5-rav" secondAttribute="bottom" constant="8" id="X7G-SZ-J0A"/>
                                            <constraint firstAttribute="trailing" secondItem="ydh-g5-rav" secondAttribute="trailing" constant="8" id="Y8C-bb-6NJ"/>
                                            <constraint firstItem="9cS-Sy-EuZ" firstAttribute="centerX" secondItem="int-s8-pcu" secondAttribute="centerX" id="ZCG-1D-yBi"/>
                                            <constraint firstItem="340" firstAttribute="centerY" secondItem="9cS-Sy-EuZ" secondAttribute="centerY" id="ZNc-pQ-IGZ"/>
                                            <constraint firstItem="ydh-g5-rav" firstAttribute="leading" secondItem="int-s8-pcu" secondAttribute="leading" constant="8" id="awW-OP-eSQ"/>
                                            <constraint firstAttribute="bottom" secondItem="9cS-Sy-EuZ" secondAttribute="bottom" constant="8" id="iEZ-Hq-0Om"/>
                                            <constraint firstAttribute="trailing" secondItem="IN3-zJ-IPm" secondAttribute="trailing" constant="8" id="pKo-cf-3VY"/>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="subviews">
                                                <exclude reference="340"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="subviews">
                                                <include reference="340"/>
                                            </mask>
                                            <mask key="constraints">
                                                <include reference="A6U-nF-gq9"/>
                                                <include reference="Nho-cn-YWA"/>
                                                <include reference="ZNc-pQ-IGZ"/>
                                                <include reference="1Om-VK-M5F"/>
                                                <include reference="EJ3-g8-zkR"/>
                                                <include reference="Rjl-vA-h01"/>
                                                <include reference="ZCG-1D-yBi"/>
                                                <include reference="iEZ-Hq-0Om"/>
                                                <include reference="2sg-eQ-dte"/>
                                                <include reference="X7G-SZ-J0A"/>
                                                <include reference="pKo-cf-3VY"/>
                                                <include reference="Vll-U9-EyK"/>
                                                <include reference="Y8C-bb-6NJ"/>
                                                <include reference="awW-OP-eSQ"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="constraints">
                                                <include reference="iEZ-Hq-0Om"/>
                                            </mask>
                                        </variation>
                                    </view>
                                    <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="Hvt-96-oQi" userLabel="Register Text Url Container">
                                        <rect key="frame" x="20" y="318" width="335" height="60"/>
                                        <subviews>
                                            <textView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" bounces="NO" scrollEnabled="NO" showsHorizontalScrollIndicator="NO" editable="NO" text="placeholder" textAlignment="center" translatesAutoresizingMaskIntoConstraints="NO" id="rRh-gi-Tzf">
                                                <rect key="frame" x="0.0" y="0.0" width="335" height="28"/>
                                                <accessibility key="accessibilityConfiguration">
                                                    <accessibilityTraits key="traits" link="YES"/>
                                                </accessibility>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="28" id="gjI-PJ-gyQ"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="12"/>
                                                <textInputTraits key="textInputTraits" autocapitalizationType="sentences"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="gjI-PJ-gyQ"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <fontDescription key="fontDescription" name="HelveticaNeue" family="Helvetica Neue" pointSize="12"/>
                                                    <mask key="constraints">
                                                        <include reference="gjI-PJ-gyQ"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="gjI-PJ-gyQ"/>
                                                    </mask>
                                                </variation>
                                            </textView>
                                            <textView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" bounces="NO" scrollEnabled="NO" showsHorizontalScrollIndicator="NO" editable="NO" text="placeholder" textAlignment="center" translatesAutoresizingMaskIntoConstraints="NO" id="4Fm-el-WnY" userLabel="Forgot Pw Link">
                                                <rect key="frame" x="0.0" y="24" width="335" height="28"/>
                                                <accessibility key="accessibilityConfiguration">
                                                    <accessibilityTraits key="traits" link="YES"/>
                                                </accessibility>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="28" id="Nao-6t-JF5"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="12"/>
                                                <textInputTraits key="textInputTraits" autocapitalizationType="sentences"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="Nao-6t-JF5"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <fontDescription key="fontDescription" name="HelveticaNeue" family="Helvetica Neue" pointSize="12"/>
                                                    <mask key="constraints">
                                                        <include reference="Nao-6t-JF5"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="Nao-6t-JF5"/>
                                                    </mask>
                                                </variation>
                                            </textView>
                                        </subviews>
                                        <constraints>
                                            <constraint firstItem="4Fm-el-WnY" firstAttribute="centerX" secondItem="Hvt-96-oQi" secondAttribute="centerX" id="0Mj-as-Nml"/>
                                            <constraint firstItem="rRh-gi-Tzf" firstAttribute="width" secondItem="Hvt-96-oQi" secondAttribute="width" id="1bE-bs-cld">
                                                <variation key="heightClass=regular-widthClass=regular" constant="0.0"/>
                                            </constraint>
                                            <constraint firstItem="rRh-gi-Tzf" firstAttribute="centerX" secondItem="Hvt-96-oQi" secondAttribute="centerX" id="IDU-d0-GTc">
                                                <variation key="heightClass=regular-widthClass=regular" constant="0.0"/>
                                            </constraint>
                                            <constraint firstItem="4Fm-el-WnY" firstAttribute="width" secondItem="Hvt-96-oQi" secondAttribute="width" id="TRS-b6-qjS"/>
                                            <constraint firstItem="rRh-gi-Tzf" firstAttribute="centerY" secondItem="Hvt-96-oQi" secondAttribute="centerY" constant="-16" id="Uvh-oy-gQV">
                                                <variation key="heightClass=regular-widthClass=regular" constant="-16"/>
                                            </constraint>
                                            <constraint firstItem="4Fm-el-WnY" firstAttribute="centerY" secondItem="Hvt-96-oQi" secondAttribute="centerY" id="agh-es-bHE">
                                                <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                                <variation key="heightClass=regular-widthClass=regular" constant="8"/>
                                            </constraint>
                                            <constraint firstAttribute="height" constant="30" id="gP9-Pd-VCb">
                                                <variation key="heightClass=regular-widthClass=compact" constant="60"/>
                                                <variation key="heightClass=regular-widthClass=regular" constant="60"/>
                                            </constraint>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="subviews">
                                                <exclude reference="4Fm-el-WnY"/>
                                            </mask>
                                            <mask key="constraints">
                                                <exclude reference="gP9-Pd-VCb"/>
                                                <exclude reference="0Mj-as-Nml"/>
                                                <exclude reference="TRS-b6-qjS"/>
                                                <exclude reference="agh-es-bHE"/>
                                                <exclude reference="1bE-bs-cld"/>
                                                <exclude reference="IDU-d0-GTc"/>
                                                <exclude reference="Uvh-oy-gQV"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="subviews">
                                                <include reference="rRh-gi-Tzf"/>
                                                <include reference="4Fm-el-WnY"/>
                                            </mask>
                                            <mask key="constraints">
                                                <include reference="gP9-Pd-VCb"/>
                                                <include reference="0Mj-as-Nml"/>
                                                <include reference="TRS-b6-qjS"/>
                                                <include reference="agh-es-bHE"/>
                                                <include reference="1bE-bs-cld"/>
                                                <include reference="IDU-d0-GTc"/>
                                                <include reference="Uvh-oy-gQV"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="subviews">
                                                <include reference="4Fm-el-WnY"/>
                                            </mask>
                                            <mask key="constraints">
                                                <include reference="gP9-Pd-VCb"/>
                                                <include reference="0Mj-as-Nml"/>
                                                <include reference="TRS-b6-qjS"/>
                                                <include reference="agh-es-bHE"/>
                                                <include reference="1bE-bs-cld"/>
                                                <include reference="IDU-d0-GTc"/>
                                                <include reference="Uvh-oy-gQV"/>
                                            </mask>
                                        </variation>
                                    </view>
                                </subviews>
                                <constraints>
                                    <constraint firstItem="int-s8-pcu" firstAttribute="leading" secondItem="bAa-Di-Ylg" secondAttribute="leading" constant="20" id="1ea-AV-VeT"/>
                                    <constraint firstItem="Hvt-96-oQi" firstAttribute="leading" secondItem="bAa-Di-Ylg" secondAttribute="leading" constant="20" id="4kB-Ok-V0S"/>
                                    <constraint firstItem="h2V-42-bDi" firstAttribute="top" secondItem="bAa-Di-Ylg" secondAttribute="top" constant="8" id="6dz-1q-5KC"/>
                                    <constraint firstItem="h2V-42-bDi" firstAttribute="centerX" secondItem="bAa-Di-Ylg" secondAttribute="centerX" id="Ggc-gi-F6t"/>
                                    <constraint firstAttribute="trailing" secondItem="int-s8-pcu" secondAttribute="trailing" constant="20" id="JVj-f4-wx1"/>
                                    <constraint firstAttribute="trailing" secondItem="Hvt-96-oQi" secondAttribute="trailing" constant="20" id="Q0h-hK-b0g"/>
                                    <constraint firstItem="int-s8-pcu" firstAttribute="centerY" secondItem="bAa-Di-Ylg" secondAttribute="centerY" id="RTF-i6-Qmv">
                                        <variation key="heightClass=regular-widthClass=compact" constant="60"/>
                                        <variation key="heightClass=regular-widthClass=regular" constant="74"/>
                                    </constraint>
                                    <constraint firstItem="int-s8-pcu" firstAttribute="centerX" secondItem="bAa-Di-Ylg" secondAttribute="centerX" id="fMM-jc-0C1"/>
                                    <constraint firstAttribute="bottom" secondItem="Hvt-96-oQi" secondAttribute="bottom" constant="8" id="qf9-ck-5mi">
                                        <variation key="heightClass=regular-widthClass=regular" constant="15"/>
                                    </constraint>
                                    <constraint firstItem="Hvt-96-oQi" firstAttribute="top" secondItem="int-s8-pcu" secondAttribute="bottom" constant="8" id="zFT-ce-MlK">
                                        <variation key="heightClass=regular-widthClass=regular" constant="25"/>
                                    </constraint>
                                </constraints>
                                <variation key="default">
                                    <mask key="subviews">
                                        <exclude reference="h2V-42-bDi"/>
                                        <exclude reference="Hvt-96-oQi"/>
                                    </mask>
                                    <mask key="constraints">
                                        <exclude reference="6dz-1q-5KC"/>
                                        <exclude reference="Ggc-gi-F6t"/>
                                        <exclude reference="4kB-Ok-V0S"/>
                                        <exclude reference="Q0h-hK-b0g"/>
                                        <exclude reference="qf9-ck-5mi"/>
                                        <exclude reference="zFT-ce-MlK"/>
                                        <exclude reference="RTF-i6-Qmv"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="h2V-42-bDi"/>
                                        <include reference="int-s8-pcu"/>
                                        <include reference="Hvt-96-oQi"/>
                                    </mask>
                                    <mask key="constraints">
                                        <include reference="6dz-1q-5KC"/>
                                        <include reference="Ggc-gi-F6t"/>
                                        <include reference="4kB-Ok-V0S"/>
                                        <include reference="Q0h-hK-b0g"/>
                                        <include reference="qf9-ck-5mi"/>
                                        <include reference="zFT-ce-MlK"/>
                                        <include reference="1ea-AV-VeT"/>
                                        <include reference="JVj-f4-wx1"/>
                                        <include reference="RTF-i6-Qmv"/>
                                        <include reference="fMM-jc-0C1"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=regular">
                                    <mask key="subviews">
                                        <include reference="h2V-42-bDi"/>
                                        <include reference="Hvt-96-oQi"/>
                                    </mask>
                                    <mask key="constraints">
                                        <include reference="6dz-1q-5KC"/>
                                        <include reference="Ggc-gi-F6t"/>
                                        <include reference="4kB-Ok-V0S"/>
                                        <include reference="Q0h-hK-b0g"/>
                                        <include reference="qf9-ck-5mi"/>
                                        <include reference="zFT-ce-MlK"/>
                                        <include reference="RTF-i6-Qmv"/>
                                    </mask>
                                </variation>
                            </view>
                        </subviews>
                        <color key="backgroundColor" red="0.27450980392156865" green="0.71372549019607845" blue="0.74117647058823533" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstItem="bAa-Di-Ylg" firstAttribute="centerY" secondItem="154" secondAttribute="centerY" id="8qU-vb-9uS">
                                <variation key="heightClass=regular-widthClass=compact" constant="0.0"/>
                                <variation key="heightClass=regular-widthClass=regular" constant="-73"/>
                            </constraint>
                            <constraint firstItem="bAa-Di-Ylg" firstAttribute="centerX" secondItem="154" secondAttribute="centerX" id="Ghm-Ki-h8Z"/>
                            <constraint firstItem="cRx-gJ-61v" firstAttribute="top" secondItem="154" secondAttribute="topMargin" id="OWB-re-VI0"/>
                            <constraint firstItem="cRx-gJ-61v" firstAttribute="leading" secondItem="154" secondAttribute="leadingMargin" constant="-20" id="Q0z-S4-UWL"/>
                            <constraint firstItem="bAa-Di-Ylg" firstAttribute="width" secondItem="154" secondAttribute="width" multiplier="0.5" id="SO5-dM-oEC"/>
                            <constraint firstItem="cRx-gJ-61v" firstAttribute="centerX" secondItem="154" secondAttribute="centerX" id="ThK-1h-C6G"/>
                            <constraint firstAttribute="trailingMargin" secondItem="cRx-gJ-61v" secondAttribute="trailing" constant="-20" id="h2L-v3-YBo"/>
                            <constraint firstItem="98" firstAttribute="top" secondItem="cRx-gJ-61v" secondAttribute="bottom" id="nfl-ap-Kkw"/>
                            <constraint firstItem="cRx-gJ-61v" firstAttribute="centerY" secondItem="154" secondAttribute="centerY" id="prW-Z1-wFS"/>
                            <constraint firstItem="bAa-Di-Ylg" firstAttribute="width" secondItem="154" secondAttribute="width" id="wRe-Tk-c5l"/>
                        </constraints>
                        <variation key="default">
                            <mask key="constraints">
                                <exclude reference="SO5-dM-oEC"/>
                                <exclude reference="wRe-Tk-c5l"/>
                                <exclude reference="OWB-re-VI0"/>
                                <exclude reference="Q0z-S4-UWL"/>
                                <exclude reference="h2L-v3-YBo"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=compact">
                            <mask key="subviews">
                                <include reference="cRx-gJ-61v"/>
                                <include reference="bAa-Di-Ylg"/>
                            </mask>
                            <mask key="constraints">
                                <include reference="wRe-Tk-c5l"/>
                                <include reference="OWB-re-VI0"/>
                                <include reference="Q0z-S4-UWL"/>
                                <include reference="h2L-v3-YBo"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=regular">
                            <mask key="constraints">
                                <include reference="SO5-dM-oEC"/>
                                <include reference="OWB-re-VI0"/>
                                <include reference="Q0z-S4-UWL"/>
                                <include reference="h2L-v3-YBo"/>
                            </mask>
                        </variation>
                    </view>
                    <navigationItem key="navigationItem" title="Title" id="385"/>
                    <connections>
                        <outlet property="ClickHereTextView" destination="rRh-gi-Tzf" id="knT-Aq-Cxm"/>
                        <outlet property="ForgotPwText" destination="4Fm-el-WnY" id="e0F-3M-yNw"/>
                        <outlet property="FormContainer" destination="bAa-Di-Ylg" id="Bfd-Ci-SzR"/>
                        <outlet property="Waiting" destination="340" id="name-outlet-340"/>
                        <outlet property="btnLogin" destination="9cS-Sy-EuZ" id="name-outlet-9cS-Sy-EuZ"/>
                        <outlet property="logoImage" destination="h2V-42-bDi" id="name-outlet-h2V-42-bDi"/>
                        <outlet property="txtEmail" destination="ydh-g5-rav" id="name-outlet-ydh-g5-rav"/>
                        <outlet property="txtPassword" destination="IN3-zJ-IPm" id="name-outlet-IN3-zJ-IPm"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="102" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="58.75" y="-55.25"/>
        </scene>
        <!--Log Hours View Controller-->
        <scene sceneID="132">
            <objects>
                <viewController storyboardIdentifier="LogHoursViewController" id="133" customClass="LogHoursViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="130"/>
                        <viewControllerLayoutGuide type="bottom" id="131"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="134">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                        <subviews>
                            <scrollView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" directionalLockEnabled="YES" bounces="NO" showsHorizontalScrollIndicator="NO" showsVerticalScrollIndicator="NO" keyboardDismissMode="interactive" translatesAutoresizingMaskIntoConstraints="NO" id="wFM-aq-xlo">
                                <rect key="frame" x="16" y="20" width="343" height="647"/>
                                <subviews>
                                    <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="360">
                                        <rect key="frame" x="20" y="0.0" width="303" height="992"/>
                                        <subviews>
                                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="ajX-8M-d7m" customClass="UploadImageContainer">
                                                <rect key="frame" x="0.0" y="8" width="303" height="128"/>
                                                <subviews>
                                                    <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="bottom" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="HGo-po-1RG" misplaced="YES">
                                                        <rect key="frame" x="8" y="0.0" width="287" height="108"/>
                                                        <state key="normal" title="Add image">
                                                            <color key="titleColor" red="0.38431372549999998" green="0.83921568629999999" blue="0.89411764709999997" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                        </state>
                                                    </button>
                                                    <imageView userInteractionEnabled="NO" contentMode="scaleToFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" image="camera_icon.png" translatesAutoresizingMaskIntoConstraints="NO" id="qu0-XW-pl3">
                                                        <rect key="frame" x="129" y="42" width="45" height="45"/>
                                                        <color key="tintColor" red="0.38431372549999998" green="0.83921568629999999" blue="0.89411764709999997" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                        <accessibility key="accessibilityConfiguration">
                                                            <accessibilityTraits key="traits" button="YES" image="YES"/>
                                                        </accessibility>
                                                        <constraints>
                                                            <constraint firstAttribute="height" constant="45" id="M7y-9E-Or0">
                                                                <variation key="heightClass=regular-widthClass=compact" constant="45"/>
                                                            </constraint>
                                                            <constraint firstAttribute="width" secondItem="qu0-XW-pl3" secondAttribute="height" multiplier="1:1" id="RzZ-Pe-GEj"/>
                                                            <constraint firstAttribute="width" constant="45" id="jPW-tv-GCE">
                                                                <variation key="heightClass=regular-widthClass=compact" constant="45"/>
                                                            </constraint>
                                                        </constraints>
                                                        <variation key="default">
                                                            <mask key="constraints">
                                                                <exclude reference="M7y-9E-Or0"/>
                                                                <exclude reference="RzZ-Pe-GEj"/>
                                                                <exclude reference="jPW-tv-GCE"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=compact">
                                                            <mask key="constraints">
                                                                <include reference="M7y-9E-Or0"/>
                                                                <include reference="RzZ-Pe-GEj"/>
                                                                <include reference="jPW-tv-GCE"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=regular">
                                                            <mask key="constraints">
                                                                <include reference="M7y-9E-Or0"/>
                                                                <include reference="RzZ-Pe-GEj"/>
                                                                <include reference="jPW-tv-GCE"/>
                                                            </mask>
                                                        </variation>
                                                    </imageView>
                                                    <imageView userInteractionEnabled="NO" contentMode="scaleAspectFit" horizontalHuggingPriority="251" verticalHuggingPriority="251" translatesAutoresizingMaskIntoConstraints="NO" id="kbq-hk-ucm">
                                                        <rect key="frame" x="0.0" y="0.0" width="303" height="128"/>
                                                        <constraints>
                                                            <constraint firstAttribute="width" constant="240" id="rWn-43-g1q"/>
                                                        </constraints>
                                                        <variation key="default">
                                                            <mask key="constraints">
                                                                <exclude reference="rWn-43-g1q"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=compact">
                                                            <mask key="constraints">
                                                                <exclude reference="rWn-43-g1q"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=regular">
                                                            <mask key="constraints">
                                                                <exclude reference="rWn-43-g1q"/>
                                                            </mask>
                                                        </variation>
                                                    </imageView>
                                                </subviews>
                                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="0.6026657919847328" colorSpace="custom" customColorSpace="sRGB"/>
                                                <constraints>
                                                    <constraint firstItem="qu0-XW-pl3" firstAttribute="centerY" secondItem="ajX-8M-d7m" secondAttribute="centerY" id="0c3-uf-Efr"/>
                                                    <constraint firstAttribute="trailing" secondItem="kbq-hk-ucm" secondAttribute="trailing" id="Bah-C5-CS2"/>
                                                    <constraint firstItem="HGo-po-1RG" firstAttribute="height" secondItem="ajX-8M-d7m" secondAttribute="height" id="L3u-lw-zWi">
                                                        <variation key="heightClass=regular-widthClass=compact" constant="-20"/>
                                                    </constraint>
                                                    <constraint firstItem="kbq-hk-ucm" firstAttribute="top" secondItem="ajX-8M-d7m" secondAttribute="top" id="Snv-oh-0Vg"/>
                                                    <constraint firstAttribute="trailing" secondItem="HGo-po-1RG" secondAttribute="trailing" constant="8" id="Y8j-Oz-g0M"/>
                                                    <constraint firstAttribute="bottom" secondItem="HGo-po-1RG" secondAttribute="bottom" constant="20" id="b8c-JD-ywd"/>
                                                    <constraint firstAttribute="height" constant="128" id="bCe-4f-YbM"/>
                                                    <constraint firstAttribute="bottom" secondItem="HGo-po-1RG" secondAttribute="bottom" constant="8" id="cnG-ES-tvh"/>
                                                    <constraint firstItem="HGo-po-1RG" firstAttribute="leading" secondItem="ajX-8M-d7m" secondAttribute="leading" id="eGa-Lb-YiE"/>
                                                    <constraint firstItem="qu0-XW-pl3" firstAttribute="centerX" secondItem="ajX-8M-d7m" secondAttribute="centerX" id="heE-EA-yqE"/>
                                                    <constraint firstItem="HGo-po-1RG" firstAttribute="centerX" secondItem="ajX-8M-d7m" secondAttribute="centerX" id="lTa-QI-Ltq"/>
                                                    <constraint firstAttribute="trailing" secondItem="HGo-po-1RG" secondAttribute="trailing" id="mdW-v8-mRf"/>
                                                    <constraint firstAttribute="bottom" secondItem="kbq-hk-ucm" secondAttribute="bottom" id="wA7-L1-cGS"/>
                                                    <constraint firstItem="HGo-po-1RG" firstAttribute="leading" secondItem="ajX-8M-d7m" secondAttribute="leading" constant="8" id="wnG-D4-4vz"/>
                                                    <constraint firstItem="kbq-hk-ucm" firstAttribute="leading" secondItem="ajX-8M-d7m" secondAttribute="leading" id="z5i-ch-0HS"/>
                                                </constraints>
                                                <variation key="default">
                                                    <mask key="subviews">
                                                        <exclude reference="qu0-XW-pl3"/>
                                                        <exclude reference="kbq-hk-ucm"/>
                                                    </mask>
                                                    <mask key="constraints">
                                                        <exclude reference="bCe-4f-YbM"/>
                                                        <exclude reference="Bah-C5-CS2"/>
                                                        <exclude reference="Snv-oh-0Vg"/>
                                                        <exclude reference="wA7-L1-cGS"/>
                                                        <exclude reference="z5i-ch-0HS"/>
                                                        <exclude reference="0c3-uf-Efr"/>
                                                        <exclude reference="heE-EA-yqE"/>
                                                        <exclude reference="L3u-lw-zWi"/>
                                                        <exclude reference="Y8j-Oz-g0M"/>
                                                        <exclude reference="b8c-JD-ywd"/>
                                                        <exclude reference="cnG-ES-tvh"/>
                                                        <exclude reference="eGa-Lb-YiE"/>
                                                        <exclude reference="lTa-QI-Ltq"/>
                                                        <exclude reference="wnG-D4-4vz"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="subviews">
                                                        <include reference="HGo-po-1RG"/>
                                                        <include reference="qu0-XW-pl3"/>
                                                        <include reference="kbq-hk-ucm"/>
                                                    </mask>
                                                    <mask key="constraints">
                                                        <include reference="bCe-4f-YbM"/>
                                                        <include reference="Bah-C5-CS2"/>
                                                        <include reference="Snv-oh-0Vg"/>
                                                        <include reference="wA7-L1-cGS"/>
                                                        <include reference="z5i-ch-0HS"/>
                                                        <include reference="0c3-uf-Efr"/>
                                                        <include reference="heE-EA-yqE"/>
                                                        <include reference="L3u-lw-zWi"/>
                                                        <include reference="Y8j-Oz-g0M"/>
                                                        <include reference="b8c-JD-ywd"/>
                                                        <exclude reference="eGa-Lb-YiE"/>
                                                        <include reference="lTa-QI-Ltq"/>
                                                        <exclude reference="mdW-v8-mRf"/>
                                                        <include reference="wnG-D4-4vz"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="subviews">
                                                        <include reference="qu0-XW-pl3"/>
                                                        <include reference="kbq-hk-ucm"/>
                                                    </mask>
                                                    <mask key="constraints">
                                                        <include reference="bCe-4f-YbM"/>
                                                        <include reference="Bah-C5-CS2"/>
                                                        <include reference="Snv-oh-0Vg"/>
                                                        <include reference="wA7-L1-cGS"/>
                                                        <include reference="z5i-ch-0HS"/>
                                                        <include reference="0c3-uf-Efr"/>
                                                        <include reference="heE-EA-yqE"/>
                                                        <include reference="Y8j-Oz-g0M"/>
                                                        <include reference="cnG-ES-tvh"/>
                                                        <exclude reference="eGa-Lb-YiE"/>
                                                        <exclude reference="lTa-QI-Ltq"/>
                                                        <exclude reference="mdW-v8-mRf"/>
                                                        <include reference="wnG-D4-4vz"/>
                                                    </mask>
                                                </variation>
                                            </view>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Number of hours" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="Ejr-Tc-3fX" misplaced="YES">
                                                <rect key="frame" x="0.0" y="184" width="303" height="17"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="pUG-M7-M7R"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <nil key="highlightedColor"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="pUG-M7-M7R"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="pUG-M7-M7R"/>
                                                    </mask>
                                                </variation>
                                            </label>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="What was the highlight?" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="eGy-pS-OYg" misplaced="YES">
                                                <rect key="frame" x="0.0" y="261" width="303" height="17"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="W8N-pb-P5L"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <nil key="highlightedColor"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="W8N-pb-P5L"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="W8N-pb-P5L"/>
                                                    </mask>
                                                </variation>
                                            </label>
                                            <textView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" showsHorizontalScrollIndicator="NO" translatesAutoresizingMaskIntoConstraints="NO" id="OBQ-Zy-vpV">
                                                <rect key="frame" x="0.0" y="286" width="303" height="120"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="120" id="f6e-d1-cQP"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits" autocapitalizationType="sentences" enablesReturnKeyAutomatically="YES"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="f6e-d1-cQP"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="f6e-d1-cQP"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="f6e-d1-cQP"/>
                                                    </mask>
                                                </variation>
                                            </textView>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Towards which challenge?" textAlignment="natural" lineBreakMode="tailTruncation" numberOfLines="2" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="for-SA-Uqi">
                                                <rect key="frame" x="0.0" y="422" width="303" height="30"/>
                                                <accessibility key="accessibilityConfiguration">
                                                    <accessibilityTraits key="traits" none="YES"/>
                                                </accessibility>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="5MT-3K-HFG"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <nil key="highlightedColor"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="5MT-3K-HFG"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="5MT-3K-HFG"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="5MT-3K-HFG"/>
                                                    </mask>
                                                </variation>
                                            </label>
                                            <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" textAlignment="natural" minimumFontSize="14" translatesAutoresizingMaskIntoConstraints="NO" id="wvL-GS-7UG" customClass="PorpoiseEditText">
                                                <rect key="frame" x="0.0" y="452" width="303" height="30"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="6Uk-Ly-NEj"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="6Uk-Ly-NEj"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="6Uk-Ly-NEj"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="6Uk-Ly-NEj"/>
                                                    </mask>
                                                </variation>
                                            </textField>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Organization Impacted" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="nIU-cB-yrh">
                                                <rect key="frame" x="0.0" y="490" width="303" height="30"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="bVB-xz-DIP"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <nil key="highlightedColor"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="bVB-xz-DIP"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="bVB-xz-DIP"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="bVB-xz-DIP"/>
                                                    </mask>
                                                </variation>
                                            </label>
                                            <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" textAlignment="natural" minimumFontSize="14" translatesAutoresizingMaskIntoConstraints="NO" id="Ujo-KJ-iNZ" customClass="PorpoiseEditText">
                                                <rect key="frame" x="0.0" y="520" width="303" height="30"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="5ia-00-sBt"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="5ia-00-sBt"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="5ia-00-sBt"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="5ia-00-sBt"/>
                                                    </mask>
                                                </variation>
                                            </textField>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Date of Activity" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="0Js-7X-6Dk">
                                                <rect key="frame" x="0.0" y="558" width="303" height="30"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="6Ym-bO-eVB"/>
                                                </constraints>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <nil key="highlightedColor"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="6Ym-bO-eVB"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="6Ym-bO-eVB"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="6Ym-bO-eVB"/>
                                                    </mask>
                                                </variation>
                                            </label>
                                            <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" text="placeholder" borderStyle="roundedRect" textAlignment="natural" minimumFontSize="14" translatesAutoresizingMaskIntoConstraints="NO" id="4al-W2-v6A" customClass="PorpoiseEditText">
                                                <rect key="frame" x="0.0" y="588" width="303" height="30"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="c8u-ne-Joi"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits" returnKeyType="done" enablesReturnKeyAutomatically="YES"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="c8u-ne-Joi"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="c8u-ne-Joi"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="c8u-ne-Joi"/>
                                                    </mask>
                                                </variation>
                                            </textField>
                                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="lAF-Sl-M7n" userLabel="Button Container">
                                                <rect key="frame" x="0.0" y="650" width="303" height="62"/>
                                                <subviews>
                                                    <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="RaD-Ed-gXI" customClass="PorpoiseButton">
                                                        <rect key="frame" x="160" y="16" width="143" height="30"/>
                                                        <constraints>
                                                            <constraint firstAttribute="height" constant="30" id="axB-lS-NAZ"/>
                                                        </constraints>
                                                        <state key="normal" title="Post">
                                                            <color key="titleColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                        </state>
                                                        <variation key="default">
                                                            <mask key="constraints">
                                                                <exclude reference="axB-lS-NAZ"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=compact">
                                                            <mask key="constraints">
                                                                <include reference="axB-lS-NAZ"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=regular">
                                                            <mask key="constraints">
                                                                <include reference="axB-lS-NAZ"/>
                                                            </mask>
                                                        </variation>
                                                    </button>
                                                    <activityIndicatorView hidden="YES" opaque="NO" contentMode="scaleToFill" horizontalHuggingPriority="750" verticalHuggingPriority="750" style="gray" translatesAutoresizingMaskIntoConstraints="NO" id="XEl-tS-PnT" userLabel="waiting">
                                                        <rect key="frame" x="115" y="21" width="20" height="20"/>
                                                        <constraints>
                                                            <constraint firstAttribute="width" constant="20" id="RyN-HG-h5C"/>
                                                            <constraint firstAttribute="height" constant="20" id="bE7-aC-ddR"/>
                                                        </constraints>
                                                        <variation key="default">
                                                            <mask key="constraints">
                                                                <exclude reference="RyN-HG-h5C"/>
                                                                <exclude reference="bE7-aC-ddR"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=compact">
                                                            <mask key="constraints">
                                                                <include reference="RyN-HG-h5C"/>
                                                                <include reference="bE7-aC-ddR"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=regular">
                                                            <mask key="constraints">
                                                                <include reference="RyN-HG-h5C"/>
                                                                <include reference="bE7-aC-ddR"/>
                                                            </mask>
                                                        </variation>
                                                    </activityIndicatorView>
                                                    <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="W5I-OI-zdM" customClass="PorpoiseButton">
                                                        <rect key="frame" x="0.0" y="16" width="135" height="30"/>
                                                        <constraints>
                                                            <constraint firstAttribute="height" constant="30" id="7rq-kX-emR"/>
                                                        </constraints>
                                                        <state key="normal" title="Cancel">
                                                            <color key="titleColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                        </state>
                                                        <variation key="default">
                                                            <mask key="constraints">
                                                                <exclude reference="7rq-kX-emR"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=compact">
                                                            <mask key="constraints">
                                                                <include reference="7rq-kX-emR"/>
                                                            </mask>
                                                        </variation>
                                                        <variation key="heightClass=regular-widthClass=regular">
                                                            <mask key="constraints">
                                                                <include reference="7rq-kX-emR"/>
                                                            </mask>
                                                        </variation>
                                                    </button>
                                                </subviews>
                                                <constraints>
                                                    <constraint firstItem="W5I-OI-zdM" firstAttribute="width" secondItem="RaD-Ed-gXI" secondAttribute="width" id="3yh-qJ-rh6">
                                                        <variation key="heightClass=regular-widthClass=compact" constant="-8"/>
                                                    </constraint>
                                                    <constraint firstItem="W5I-OI-zdM" firstAttribute="centerY" secondItem="lAF-Sl-M7n" secondAttribute="centerY" id="53t-p9-NAg"/>
                                                    <constraint firstAttribute="height" constant="62" id="Aaw-5h-G7S"/>
                                                    <constraint firstItem="RaD-Ed-gXI" firstAttribute="width" secondItem="lAF-Sl-M7n" secondAttribute="width" multiplier="0.5" id="Bet-Yp-fOK">
                                                        <variation key="heightClass=regular-widthClass=compact" constant="-8"/>
                                                        <variation key="heightClass=regular-widthClass=regular" constant="-20"/>
                                                    </constraint>
                                                    <constraint firstItem="W5I-OI-zdM" firstAttribute="leading" secondItem="lAF-Sl-M7n" secondAttribute="leading" constant="8" id="DD4-pm-np2">
                                                        <variation key="heightClass=regular-widthClass=compact" constant="0.0"/>
                                                        <variation key="heightClass=regular-widthClass=regular" constant="0.0"/>
                                                    </constraint>
                                                    <constraint firstItem="XEl-tS-PnT" firstAttribute="centerY" secondItem="lAF-Sl-M7n" secondAttribute="centerY" id="cOc-Mx-dlu"/>
                                                    <constraint firstItem="RaD-Ed-gXI" firstAttribute="centerY" secondItem="lAF-Sl-M7n" secondAttribute="centerY" id="eYx-eb-Akd"/>
                                                    <constraint firstAttribute="trailing" secondItem="RaD-Ed-gXI" secondAttribute="trailing" constant="8" id="qut-d1-tno">
                                                        <variation key="heightClass=regular-widthClass=compact" constant="0.0"/>
                                                        <variation key="heightClass=regular-widthClass=regular" constant="0.0"/>
                                                    </constraint>
                                                    <constraint firstItem="XEl-tS-PnT" firstAttribute="trailing" secondItem="W5I-OI-zdM" secondAttribute="trailing" id="yiX-yU-zSn">
                                                        <variation key="heightClass=regular-widthClass=regular" constant="4"/>
                                                    </constraint>
                                                </constraints>
                                                <variation key="default">
                                                    <mask key="subviews">
                                                        <exclude reference="XEl-tS-PnT"/>
                                                    </mask>
                                                    <mask key="constraints">
                                                        <exclude reference="Aaw-5h-G7S"/>
                                                        <exclude reference="3yh-qJ-rh6"/>
                                                        <exclude reference="53t-p9-NAg"/>
                                                        <exclude reference="DD4-pm-np2"/>
                                                        <exclude reference="cOc-Mx-dlu"/>
                                                        <exclude reference="yiX-yU-zSn"/>
                                                        <exclude reference="Bet-Yp-fOK"/>
                                                        <exclude reference="eYx-eb-Akd"/>
                                                        <exclude reference="qut-d1-tno"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="subviews">
                                                        <include reference="RaD-Ed-gXI"/>
                                                        <include reference="XEl-tS-PnT"/>
                                                        <include reference="W5I-OI-zdM"/>
                                                    </mask>
                                                    <mask key="constraints">
                                                        <include reference="Aaw-5h-G7S"/>
                                                        <include reference="3yh-qJ-rh6"/>
                                                        <include reference="53t-p9-NAg"/>
                                                        <include reference="DD4-pm-np2"/>
                                                        <include reference="cOc-Mx-dlu"/>
                                                        <include reference="yiX-yU-zSn"/>
                                                        <include reference="Bet-Yp-fOK"/>
                                                        <include reference="eYx-eb-Akd"/>
                                                        <include reference="qut-d1-tno"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="subviews">
                                                        <include reference="RaD-Ed-gXI"/>
                                                        <include reference="XEl-tS-PnT"/>
                                                    </mask>
                                                    <mask key="constraints">
                                                        <include reference="Aaw-5h-G7S"/>
                                                        <include reference="3yh-qJ-rh6"/>
                                                        <include reference="53t-p9-NAg"/>
                                                        <include reference="DD4-pm-np2"/>
                                                        <include reference="cOc-Mx-dlu"/>
                                                        <include reference="yiX-yU-zSn"/>
                                                        <include reference="Bet-Yp-fOK"/>
                                                        <include reference="eYx-eb-Akd"/>
                                                        <include reference="qut-d1-tno"/>
                                                    </mask>
                                                </variation>
                                            </view>
                                            <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" textAlignment="natural" minimumFontSize="14" translatesAutoresizingMaskIntoConstraints="NO" id="vTW-d9-Wur" customClass="PorpoiseEditText" misplaced="YES">
                                                <rect key="frame" x="0.0" y="209" width="303" height="30"/>
                                                <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="30" id="VlV-EQ-PiE"/>
                                                </constraints>
                                                <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                                <textInputTraits key="textInputTraits" keyboardType="decimalPad"/>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="VlV-EQ-PiE"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="VlV-EQ-PiE"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <mask key="constraints">
                                                        <include reference="VlV-EQ-PiE"/>
                                                    </mask>
                                                </variation>
                                            </textField>
                                        </subviews>
                                        <constraints>
                                            <constraint firstItem="ajX-8M-d7m" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="01q-wm-TWa"/>
                                            <constraint firstItem="eGy-pS-OYg" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="2tj-vA-PJF"/>
                                            <constraint firstAttribute="trailing" secondItem="Ejr-Tc-3fX" secondAttribute="trailing" id="4DL-q4-pXV">
                                                <variation key="heightClass=regular-widthClass=regular" constant="0.0"/>
                                            </constraint>
                                            <constraint firstItem="OBQ-Zy-vpV" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="6Xc-Qb-ZQq"/>
                                            <constraint firstItem="for-SA-Uqi" firstAttribute="top" secondItem="OBQ-Zy-vpV" secondAttribute="bottom" constant="16" id="6gU-eJ-VXE"/>
                                            <constraint firstAttribute="trailing" secondItem="eGy-pS-OYg" secondAttribute="trailing" id="72r-uY-TkK"/>
                                            <constraint firstItem="Ejr-Tc-3fX" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="7XZ-LF-X0a"/>
                                            <constraint firstItem="wvL-GS-7UG" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="9WG-wF-aN6"/>
                                            <constraint firstItem="lAF-Sl-M7n" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="EJg-wB-H9g"/>
                                            <constraint firstAttribute="height" constant="992" id="F3g-lg-DZe"/>
                                            <constraint firstItem="nIU-cB-yrh" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="Ggw-wd-LJE"/>
                                            <constraint firstItem="vTW-d9-Wur" firstAttribute="trailing" secondItem="Ejr-Tc-3fX" secondAttribute="trailing" id="IyQ-pA-25H"/>
                                            <constraint firstAttribute="trailing" secondItem="Ujo-KJ-iNZ" secondAttribute="trailing" id="Ma6-ng-qcb"/>
                                            <constraint firstItem="wvL-GS-7UG" firstAttribute="top" secondItem="for-SA-Uqi" secondAttribute="bottom" id="NUO-4J-Ovq"/>
                                            <constraint firstAttribute="trailing" secondItem="0Js-7X-6Dk" secondAttribute="trailing" id="Nti-PB-giD"/>
                                            <constraint firstItem="Ujo-KJ-iNZ" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="OTc-Vh-wd7"/>
                                            <constraint firstItem="vTW-d9-Wur" firstAttribute="top" secondItem="Ejr-Tc-3fX" secondAttribute="bottom" constant="8" symbolic="YES" id="Rls-wX-Rk8"/>
                                            <constraint firstItem="wvL-GS-7UG" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="SRO-17-gDc"/>
                                            <constraint firstItem="nIU-cB-yrh" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="Um5-cH-Rbz"/>
                                            <constraint firstItem="vTW-d9-Wur" firstAttribute="leading" secondItem="Ejr-Tc-3fX" secondAttribute="leading" id="Ur5-IJ-YDY"/>
                                            <constraint firstItem="ajX-8M-d7m" firstAttribute="leading" secondItem="360" secondAttribute="leading" constant="81" id="Vzm-SE-SX3">
                                                <variation key="heightClass=regular-widthClass=regular" constant="40"/>
                                            </constraint>
                                            <constraint firstItem="Ujo-KJ-iNZ" firstAttribute="top" secondItem="nIU-cB-yrh" secondAttribute="bottom" id="Wty-Oh-czl">
                                                <variation key="heightClass=regular-widthClass=compact" constant="0.0"/>
                                            </constraint>
                                            <constraint firstAttribute="trailing" secondItem="OBQ-Zy-vpV" secondAttribute="trailing" id="WzX-1G-nwS"/>
                                            <constraint firstItem="4al-W2-v6A" firstAttribute="top" secondItem="0Js-7X-6Dk" secondAttribute="bottom" constant="8" id="XCI-52-IGa">
                                                <variation key="heightClass=regular-widthClass=compact" constant="0.0"/>
                                            </constraint>
                                            <constraint firstItem="eGy-pS-OYg" firstAttribute="top" secondItem="vTW-d9-Wur" secondAttribute="bottom" constant="22" id="YOF-hX-yPg"/>
                                            <constraint firstItem="ajX-8M-d7m" firstAttribute="top" secondItem="360" secondAttribute="top" id="ZeO-gD-TjN">
                                                <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                                <variation key="heightClass=regular-widthClass=regular" constant="24"/>
                                            </constraint>
                                            <constraint firstAttribute="trailing" secondItem="4al-W2-v6A" secondAttribute="trailing" id="aHE-Fc-DoG"/>
                                            <constraint firstItem="Ujo-KJ-iNZ" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="afg-Kl-gjN"/>
                                            <constraint firstItem="ajX-8M-d7m" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="eW4-We-p9v"/>
                                            <constraint firstItem="lAF-Sl-M7n" firstAttribute="top" secondItem="4al-W2-v6A" secondAttribute="bottom" constant="32" id="erI-Q3-466">
                                                <variation key="heightClass=regular-widthClass=compact" constant="32"/>
                                            </constraint>
                                            <constraint firstItem="OBQ-Zy-vpV" firstAttribute="top" secondItem="eGy-pS-OYg" secondAttribute="bottom" constant="8" id="hEc-Ly-7gb"/>
                                            <constraint firstAttribute="trailing" secondItem="wvL-GS-7UG" secondAttribute="trailing" id="hVH-Ja-6dV"/>
                                            <constraint firstItem="4al-W2-v6A" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="iym-Xe-sIr"/>
                                            <constraint firstAttribute="trailing" secondItem="lAF-Sl-M7n" secondAttribute="trailing" id="kCB-6A-4db"/>
                                            <constraint firstAttribute="trailing" secondItem="ajX-8M-d7m" secondAttribute="trailing" id="klY-TR-zB6">
                                                <variation key="heightClass=regular-widthClass=regular" constant="40"/>
                                            </constraint>
                                            <constraint firstItem="lAF-Sl-M7n" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="lkJ-dm-EV9"/>
                                            <constraint firstAttribute="trailing" secondItem="for-SA-Uqi" secondAttribute="trailing" id="m4Y-SS-HHJ"/>
                                            <constraint firstItem="nIU-cB-yrh" firstAttribute="top" secondItem="wvL-GS-7UG" secondAttribute="bottom" constant="8" id="mb1-sR-kRa"/>
                                            <constraint firstItem="0Js-7X-6Dk" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="oMO-uB-GqE"/>
                                            <constraint firstItem="0Js-7X-6Dk" firstAttribute="top" secondItem="Ujo-KJ-iNZ" secondAttribute="bottom" constant="8" id="oSl-9K-oTK">
                                                <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                            </constraint>
                                            <constraint firstAttribute="trailing" secondItem="nIU-cB-yrh" secondAttribute="trailing" id="pWu-Qm-pbW"/>
                                            <constraint firstItem="Ejr-Tc-3fX" firstAttribute="top" secondItem="ajX-8M-d7m" secondAttribute="bottom" constant="48" id="sYQ-qH-Ric"/>
                                            <constraint firstItem="ajX-8M-d7m" firstAttribute="centerX" secondItem="360" secondAttribute="centerX" id="u88-EZ-sx6"/>
                                            <constraint firstItem="0Js-7X-6Dk" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="vSF-xH-wes"/>
                                            <constraint firstItem="for-SA-Uqi" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="vsw-Rp-ZDx">
                                                <variation key="heightClass=regular-widthClass=compact" constant="0.0"/>
                                            </constraint>
                                            <constraint firstItem="4al-W2-v6A" firstAttribute="leading" secondItem="360" secondAttribute="leading" id="zOe-cJ-f2o"/>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="subviews">
                                                <exclude reference="Ejr-Tc-3fX"/>
                                                <exclude reference="eGy-pS-OYg"/>
                                                <exclude reference="OBQ-Zy-vpV"/>
                                            </mask>
                                            <mask key="constraints">
                                                <exclude reference="F3g-lg-DZe"/>
                                                <exclude reference="NUO-4J-Ovq"/>
                                                <exclude reference="SRO-17-gDc"/>
                                                <exclude reference="hVH-Ja-6dV"/>
                                                <exclude reference="Ggw-wd-LJE"/>
                                                <exclude reference="Um5-cH-Rbz"/>
                                                <exclude reference="mb1-sR-kRa"/>
                                                <exclude reference="pWu-Qm-pbW"/>
                                                <exclude reference="Ma6-ng-qcb"/>
                                                <exclude reference="OTc-Vh-wd7"/>
                                                <exclude reference="Wty-Oh-czl"/>
                                                <exclude reference="afg-Kl-gjN"/>
                                                <exclude reference="Nti-PB-giD"/>
                                                <exclude reference="oMO-uB-GqE"/>
                                                <exclude reference="oSl-9K-oTK"/>
                                                <exclude reference="vSF-xH-wes"/>
                                                <exclude reference="XCI-52-IGa"/>
                                                <exclude reference="aHE-Fc-DoG"/>
                                                <exclude reference="iym-Xe-sIr"/>
                                                <exclude reference="zOe-cJ-f2o"/>
                                                <exclude reference="EJg-wB-H9g"/>
                                                <exclude reference="erI-Q3-466"/>
                                                <exclude reference="kCB-6A-4db"/>
                                                <exclude reference="lkJ-dm-EV9"/>
                                                <exclude reference="4DL-q4-pXV"/>
                                                <exclude reference="7XZ-LF-X0a"/>
                                                <exclude reference="sYQ-qH-Ric"/>
                                                <exclude reference="01q-wm-TWa"/>
                                                <exclude reference="Vzm-SE-SX3"/>
                                                <exclude reference="ZeO-gD-TjN"/>
                                                <exclude reference="eW4-We-p9v"/>
                                                <exclude reference="klY-TR-zB6"/>
                                                <exclude reference="u88-EZ-sx6"/>
                                                <exclude reference="6gU-eJ-VXE"/>
                                                <exclude reference="m4Y-SS-HHJ"/>
                                                <exclude reference="vsw-Rp-ZDx"/>
                                                <exclude reference="9WG-wF-aN6"/>
                                                <exclude reference="2tj-vA-PJF"/>
                                                <exclude reference="72r-uY-TkK"/>
                                                <exclude reference="6Xc-Qb-ZQq"/>
                                                <exclude reference="WzX-1G-nwS"/>
                                                <exclude reference="hEc-Ly-7gb"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="subviews">
                                                <include reference="ajX-8M-d7m"/>
                                                <include reference="Ejr-Tc-3fX"/>
                                                <include reference="eGy-pS-OYg"/>
                                                <include reference="OBQ-Zy-vpV"/>
                                                <include reference="for-SA-Uqi"/>
                                                <include reference="wvL-GS-7UG"/>
                                                <include reference="nIU-cB-yrh"/>
                                                <include reference="Ujo-KJ-iNZ"/>
                                                <include reference="0Js-7X-6Dk"/>
                                                <include reference="4al-W2-v6A"/>
                                                <include reference="lAF-Sl-M7n"/>
                                            </mask>
                                            <mask key="constraints">
                                                <include reference="F3g-lg-DZe"/>
                                                <include reference="NUO-4J-Ovq"/>
                                                <include reference="SRO-17-gDc"/>
                                                <include reference="hVH-Ja-6dV"/>
                                                <include reference="Ggw-wd-LJE"/>
                                                <include reference="Um5-cH-Rbz"/>
                                                <include reference="mb1-sR-kRa"/>
                                                <include reference="pWu-Qm-pbW"/>
                                                <include reference="Ma6-ng-qcb"/>
                                                <include reference="OTc-Vh-wd7"/>
                                                <include reference="Wty-Oh-czl"/>
                                                <include reference="afg-Kl-gjN"/>
                                                <include reference="Nti-PB-giD"/>
                                                <include reference="oMO-uB-GqE"/>
                                                <include reference="oSl-9K-oTK"/>
                                                <include reference="vSF-xH-wes"/>
                                                <include reference="XCI-52-IGa"/>
                                                <include reference="aHE-Fc-DoG"/>
                                                <include reference="iym-Xe-sIr"/>
                                                <include reference="zOe-cJ-f2o"/>
                                                <include reference="EJg-wB-H9g"/>
                                                <include reference="erI-Q3-466"/>
                                                <include reference="kCB-6A-4db"/>
                                                <include reference="lkJ-dm-EV9"/>
                                                <include reference="4DL-q4-pXV"/>
                                                <include reference="7XZ-LF-X0a"/>
                                                <include reference="sYQ-qH-Ric"/>
                                                <include reference="ZeO-gD-TjN"/>
                                                <include reference="eW4-We-p9v"/>
                                                <include reference="klY-TR-zB6"/>
                                                <include reference="u88-EZ-sx6"/>
                                                <include reference="6gU-eJ-VXE"/>
                                                <include reference="m4Y-SS-HHJ"/>
                                                <include reference="vsw-Rp-ZDx"/>
                                                <include reference="9WG-wF-aN6"/>
                                                <include reference="2tj-vA-PJF"/>
                                                <include reference="72r-uY-TkK"/>
                                                <include reference="6Xc-Qb-ZQq"/>
                                                <include reference="WzX-1G-nwS"/>
                                                <include reference="hEc-Ly-7gb"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="subviews">
                                                <include reference="Ejr-Tc-3fX"/>
                                                <include reference="eGy-pS-OYg"/>
                                                <include reference="OBQ-Zy-vpV"/>
                                            </mask>
                                            <mask key="constraints">
                                                <include reference="F3g-lg-DZe"/>
                                                <include reference="NUO-4J-Ovq"/>
                                                <include reference="SRO-17-gDc"/>
                                                <include reference="hVH-Ja-6dV"/>
                                                <include reference="Ggw-wd-LJE"/>
                                                <include reference="Um5-cH-Rbz"/>
                                                <include reference="mb1-sR-kRa"/>
                                                <include reference="pWu-Qm-pbW"/>
                                                <include reference="Ma6-ng-qcb"/>
                                                <include reference="OTc-Vh-wd7"/>
                                                <include reference="Wty-Oh-czl"/>
                                                <include reference="afg-Kl-gjN"/>
                                                <include reference="Nti-PB-giD"/>
                                                <include reference="oMO-uB-GqE"/>
                                                <include reference="oSl-9K-oTK"/>
                                                <include reference="XCI-52-IGa"/>
                                                <include reference="aHE-Fc-DoG"/>
                                                <include reference="iym-Xe-sIr"/>
                                                <include reference="zOe-cJ-f2o"/>
                                                <include reference="EJg-wB-H9g"/>
                                                <include reference="erI-Q3-466"/>
                                                <include reference="kCB-6A-4db"/>
                                                <include reference="lkJ-dm-EV9"/>
                                                <include reference="4DL-q4-pXV"/>
                                                <include reference="7XZ-LF-X0a"/>
                                                <include reference="sYQ-qH-Ric"/>
                                                <include reference="01q-wm-TWa"/>
                                                <include reference="Vzm-SE-SX3"/>
                                                <include reference="ZeO-gD-TjN"/>
                                                <exclude reference="eW4-We-p9v"/>
                                                <include reference="klY-TR-zB6"/>
                                                <exclude reference="u88-EZ-sx6"/>
                                                <include reference="6gU-eJ-VXE"/>
                                                <include reference="m4Y-SS-HHJ"/>
                                                <include reference="vsw-Rp-ZDx"/>
                                                <include reference="9WG-wF-aN6"/>
                                                <include reference="2tj-vA-PJF"/>
                                                <include reference="72r-uY-TkK"/>
                                                <include reference="6Xc-Qb-ZQq"/>
                                                <include reference="WzX-1G-nwS"/>
                                                <include reference="hEc-Ly-7gb"/>
                                            </mask>
                                        </variation>
                                    </view>
                                </subviews>
                                <constraints>
                                    <constraint firstItem="360" firstAttribute="top" secondItem="wFM-aq-xlo" secondAttribute="top" id="C78-we-PTu"/>
                                    <constraint firstItem="360" firstAttribute="width" secondItem="wFM-aq-xlo" secondAttribute="width" multiplier="0.75" id="GGc-SQ-i7b"/>
                                    <constraint firstAttribute="trailing" secondItem="360" secondAttribute="trailing" id="Gh4-tX-trR">
                                        <variation key="heightClass=regular-widthClass=compact" constant="20"/>
                                    </constraint>
                                    <constraint firstItem="360" firstAttribute="leading" secondItem="wFM-aq-xlo" secondAttribute="leading" id="JJ4-7p-Qeo">
                                        <variation key="heightClass=regular-widthClass=compact" constant="20"/>
                                    </constraint>
                                    <constraint firstItem="360" firstAttribute="centerX" secondItem="wFM-aq-xlo" secondAttribute="centerX" id="T3a-sS-cCT"/>
                                    <constraint firstItem="360" firstAttribute="width" secondItem="wFM-aq-xlo" secondAttribute="width" id="dmU-9o-Rr6">
                                        <variation key="heightClass=regular-widthClass=compact" constant="-40"/>
                                    </constraint>
                                    <constraint firstAttribute="bottom" secondItem="360" secondAttribute="bottom" constant="44" id="ggx-9P-WFm">
                                        <variation key="heightClass=regular-widthClass=regular" constant="0.0"/>
                                    </constraint>
                                    <constraint firstItem="360" firstAttribute="top" secondItem="wFM-aq-xlo" secondAttribute="top" id="y7k-ov-6Zn"/>
                                    <constraint firstAttribute="bottom" secondItem="360" secondAttribute="bottom" id="yiD-ef-FhR">
                                        <variation key="heightClass=regular-widthClass=compact" constant="8"/>
                                    </constraint>
                                </constraints>
                                <variation key="default">
                                    <mask key="constraints">
                                        <exclude reference="C78-we-PTu"/>
                                        <exclude reference="GGc-SQ-i7b"/>
                                        <exclude reference="Gh4-tX-trR"/>
                                        <exclude reference="JJ4-7p-Qeo"/>
                                        <exclude reference="T3a-sS-cCT"/>
                                        <exclude reference="dmU-9o-Rr6"/>
                                        <exclude reference="ggx-9P-WFm"/>
                                        <exclude reference="y7k-ov-6Zn"/>
                                        <exclude reference="yiD-ef-FhR"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="360"/>
                                    </mask>
                                    <mask key="constraints">
                                        <include reference="C78-we-PTu"/>
                                        <include reference="Gh4-tX-trR"/>
                                        <include reference="JJ4-7p-Qeo"/>
                                        <include reference="dmU-9o-Rr6"/>
                                        <include reference="yiD-ef-FhR"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=regular">
                                    <mask key="constraints">
                                        <include reference="GGc-SQ-i7b"/>
                                        <exclude reference="Gh4-tX-trR"/>
                                        <exclude reference="JJ4-7p-Qeo"/>
                                        <include reference="T3a-sS-cCT"/>
                                        <include reference="ggx-9P-WFm"/>
                                        <include reference="y7k-ov-6Zn"/>
                                    </mask>
                                </variation>
                            </scrollView>
                        </subviews>
                        <color key="backgroundColor" red="0.38431372549999998" green="0.83921568629999999" blue="0.89411764709999997" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="trailing" secondItem="134" secondAttribute="trailingMargin" id="5nm-nV-5GS"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="top" secondItem="134" secondAttribute="topMargin" constant="20" id="9hm-2N-jcb"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="centerY" secondItem="134" secondAttribute="centerY" id="HVl-3l-ulK"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="centerY" secondItem="134" secondAttribute="centerY" constant="20" id="NHa-9P-BxE"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="top" secondItem="134" secondAttribute="topMargin" id="RFd-SR-lWl"/>
                            <constraint firstItem="131" firstAttribute="top" secondItem="wFM-aq-xlo" secondAttribute="bottom" id="Uz7-E7-OZG"/>
                            <constraint firstItem="131" firstAttribute="top" secondItem="wFM-aq-xlo" secondAttribute="bottom" id="Vcv-im-aVr"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="leading" secondItem="134" secondAttribute="leadingMargin" id="mBb-CS-o5w"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="centerX" secondItem="134" secondAttribute="centerX" id="p9L-rI-iBe"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="width" secondItem="134" secondAttribute="width" multiplier="0.75" id="seP-fo-UtZ"/>
                            <constraint firstItem="wFM-aq-xlo" firstAttribute="centerX" secondItem="134" secondAttribute="centerX" id="woB-Qd-yCa"/>
                        </constraints>
                        <variation key="default">
                            <mask key="constraints">
                                <exclude reference="5nm-nV-5GS"/>
                                <exclude reference="9hm-2N-jcb"/>
                                <exclude reference="HVl-3l-ulK"/>
                                <exclude reference="NHa-9P-BxE"/>
                                <exclude reference="RFd-SR-lWl"/>
                                <exclude reference="mBb-CS-o5w"/>
                                <exclude reference="p9L-rI-iBe"/>
                                <exclude reference="seP-fo-UtZ"/>
                                <exclude reference="woB-Qd-yCa"/>
                                <exclude reference="Uz7-E7-OZG"/>
                                <exclude reference="Vcv-im-aVr"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=compact">
                            <mask key="subviews">
                                <include reference="wFM-aq-xlo"/>
                            </mask>
                            <mask key="constraints">
                                <include reference="5nm-nV-5GS"/>
                                <include reference="9hm-2N-jcb"/>
                                <exclude reference="NHa-9P-BxE"/>
                                <include reference="mBb-CS-o5w"/>
                                <include reference="p9L-rI-iBe"/>
                                <include reference="Vcv-im-aVr"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=regular">
                            <mask key="constraints">
                                <exclude reference="5nm-nV-5GS"/>
                                <include reference="HVl-3l-ulK"/>
                                <exclude reference="NHa-9P-BxE"/>
                                <include reference="RFd-SR-lWl"/>
                                <include reference="seP-fo-UtZ"/>
                                <include reference="woB-Qd-yCa"/>
                                <include reference="Uz7-E7-OZG"/>
                            </mask>
                        </variation>
                    </view>
                    <connections>
                        <outlet property="AddImage" destination="HGo-po-1RG" id="0h6-CB-H6B"/>
                        <outlet property="CameraIcon" destination="qu0-XW-pl3" id="YaY-Wl-Oqf"/>
                        <outlet property="DateSelection" destination="4al-W2-v6A" id="OHm-3F-Unm"/>
                        <outlet property="GoalSelection" destination="wvL-GS-7UG" id="yea-sk-fEo"/>
                        <outlet property="Highlight" destination="OBQ-Zy-vpV" id="PEs-x4-FMI"/>
                        <outlet property="Hour" destination="vTW-d9-Wur" id="name-outlet-vTW-d9-Wur"/>
                        <outlet property="LogHoursContainer" destination="360" id="name-outlet-360"/>
                        <outlet property="OrganisationSelection" destination="Ujo-KJ-iNZ" id="dZe-Ft-47Q"/>
                        <outlet property="ScrollView" destination="wFM-aq-xlo" id="llP-G2-m5s"/>
                        <outlet property="UploadedImage" destination="kbq-hk-ucm" id="ZUv-Mh-J3k"/>
                        <outlet property="btnCancel" destination="W5I-OI-zdM" id="kLY-20-wUw"/>
                        <outlet property="btnDone" destination="RaD-Ed-gXI" id="D4f-4E-RJr"/>
                        <outlet property="waiting" destination="XEl-tS-PnT" id="Duh-j5-8Sp"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="135" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="-1133.75" y="1181.25"/>
        </scene>
        <!--Profile View Controller-->
        <scene sceneID="vTq-x8-PnA">
            <objects>
                <viewController storyboardIdentifier="ProfileViewController" id="zhf-Us-MDP" customClass="ProfileViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="9vJ-fx-fSy"/>
                        <viewControllerLayoutGuide type="bottom" id="c6H-0P-Zmz"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="7lR-R9-aiK">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <view hidden="YES" contentMode="scaleToFill" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="JPD-6D-js7">
                                <rect key="frame" x="0.0" y="0.0" width="375" height="1024"/>
                                <subviews>
                                    <activityIndicatorView opaque="NO" contentMode="scaleToFill" horizontalHuggingPriority="750" verticalHuggingPriority="750" animating="YES" style="gray" translatesAutoresizingMaskIntoConstraints="NO" id="RnJ-ie-tZ2">
                                        <rect key="frame" x="178" y="328" width="20" height="20"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="20" id="5eK-wm-Vyv">
                                                <variation key="heightClass=regular-widthClass=regular" constant="40"/>
                                            </constraint>
                                            <constraint firstAttribute="height" constant="20" id="hXu-HW-ojX">
                                                <variation key="heightClass=regular-widthClass=regular" constant="40"/>
                                            </constraint>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="5eK-wm-Vyv"/>
                                                <exclude reference="hXu-HW-ojX"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="5eK-wm-Vyv"/>
                                                <include reference="hXu-HW-ojX"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="constraints">
                                                <include reference="5eK-wm-Vyv"/>
                                                <include reference="hXu-HW-ojX"/>
                                            </mask>
                                        </variation>
                                    </activityIndicatorView>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="0.74528556034482762" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="width" constant="375" id="764"/>
                                    <constraint firstAttribute="height" constant="667" id="765"/>
                                    <constraint firstAttribute="trailing" secondItem="RnJ-ie-tZ2" secondAttribute="trailing" constant="177" id="883"/>
                                    <constraint firstAttribute="bottom" secondItem="RnJ-ie-tZ2" secondAttribute="bottom" constant="319" id="884"/>
                                    <constraint firstItem="RnJ-ie-tZ2" firstAttribute="centerX" secondItem="JPD-6D-js7" secondAttribute="centerX" id="PwC-7u-Lgq"/>
                                    <constraint firstItem="RnJ-ie-tZ2" firstAttribute="top" secondItem="JPD-6D-js7" secondAttribute="top" constant="328" id="ceY-OX-aH4"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="subviews">
                                        <exclude reference="RnJ-ie-tZ2"/>
                                    </mask>
                                    <mask key="constraints">
                                        <exclude reference="764"/>
                                        <exclude reference="765"/>
                                        <exclude reference="883"/>
                                        <exclude reference="884"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="RnJ-ie-tZ2"/>
                                    </mask>
                                    <mask key="constraints">
                                        <include reference="764"/>
                                        <include reference="765"/>
                                        <include reference="883"/>
                                        <include reference="884"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=regular">
                                    <mask key="subviews">
                                        <include reference="RnJ-ie-tZ2"/>
                                    </mask>
                                </variation>
                            </view>
                            <tableView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" bounces="NO" dataMode="prototypes" style="plain" rowHeight="44" sectionHeaderHeight="28" sectionFooterHeight="28" translatesAutoresizingMaskIntoConstraints="NO" id="nuy-vl-gIN" misplaced="YES">
                                <rect key="frame" x="0.0" y="67" width="375" height="600"/>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="width" constant="375" id="vsj-pk-X8n"/>
                                </constraints>
                                <color key="sectionIndexBackgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <scrollView key="tableHeaderView" clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" directionalLockEnabled="YES" bounces="NO" showsVerticalScrollIndicator="NO" id="krC-UU-cB7">
                                    <rect key="frame" x="0.0" y="0.0" width="375" height="283"/>
                                    <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                                    <subviews>
                                        <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="CHALLENGES" textAlignment="center" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="tTy-rb-KlI" misplaced="YES">
                                            <rect key="frame" x="0.0" y="100" width="375" height="21"/>
                                            <constraints>
                                                <constraint firstAttribute="height" constant="21" id="1385"/>
                                                <constraint firstAttribute="width" constant="375" id="1386"/>
                                            </constraints>
                                            <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                            <color key="textColor" red="0.0" green="0.0" blue="0.0" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <nil key="highlightedColor"/>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="1385"/>
                                                    <exclude reference="1386"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact">
                                                <mask key="constraints">
                                                    <include reference="1385"/>
                                                    <include reference="1386"/>
                                                </mask>
                                            </variation>
                                        </label>
                                        <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="efo-1p-QSX" userLabel="Arrow Holder" misplaced="YES">
                                            <rect key="frame" x="8" y="212" width="359" height="36"/>
                                            <constraints>
                                                <constraint firstAttribute="height" constant="24" id="vXF-mK-cc0">
                                                    <variation key="heightClass=regular-widthClass=compact" constant="36"/>
                                                    <variation key="heightClass=regular-widthClass=regular" constant="28"/>
                                                </constraint>
                                            </constraints>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="vXF-mK-cc0"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact">
                                                <mask key="constraints">
                                                    <include reference="vXF-mK-cc0"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=regular">
                                                <mask key="constraints">
                                                    <include reference="vXF-mK-cc0"/>
                                                </mask>
                                            </variation>
                                        </view>
                                        <scrollView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleAspectFit" directionalLockEnabled="YES" bounces="NO" pagingEnabled="YES" showsVerticalScrollIndicator="NO" bouncesZoom="NO" translatesAutoresizingMaskIntoConstraints="NO" id="OD3-hj-TeA" userLabel="GoalProgressScrollView" customClass="CustomGoalScrollView" misplaced="YES">
                                            <rect key="frame" x="36" y="126" width="311" height="128"/>
                                            <constraints>
                                                <constraint firstAttribute="width" constant="311" id="1388"/>
                                                <constraint firstAttribute="height" constant="128" id="1389"/>
                                            </constraints>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="1388"/>
                                                    <exclude reference="1389"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact">
                                                <mask key="constraints">
                                                    <include reference="1388"/>
                                                    <include reference="1389"/>
                                                </mask>
                                            </variation>
                                        </scrollView>
                                        <imageView userInteractionEnabled="NO" contentMode="scaleAspectFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" image="left_arrow.png" translatesAutoresizingMaskIntoConstraints="NO" id="bFU-7W-h1D" misplaced="YES">
                                            <rect key="frame" x="8" y="176" width="28" height="28"/>
                                            <constraints>
                                                <constraint firstAttribute="height" constant="28" id="1392"/>
                                                <constraint firstAttribute="width" constant="28" id="1393"/>
                                            </constraints>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="1392"/>
                                                    <exclude reference="1393"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact">
                                                <mask key="constraints">
                                                    <include reference="1392"/>
                                                    <include reference="1393"/>
                                                </mask>
                                            </variation>
                                        </imageView>
                                        <imageView userInteractionEnabled="NO" contentMode="scaleAspectFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" image="right_arrow.png" translatesAutoresizingMaskIntoConstraints="NO" id="Fsu-9x-aHs" misplaced="YES">
                                            <rect key="frame" x="347" y="176" width="28" height="28"/>
                                            <constraints>
                                                <constraint firstAttribute="height" constant="28" id="1396"/>
                                                <constraint firstAttribute="width" constant="28" id="1397"/>
                                                <constraint firstAttribute="height" constant="28" id="R91-0E-O6o"/>
                                                <constraint firstAttribute="width" constant="28" id="XL5-0y-rfc"/>
                                            </constraints>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="1396"/>
                                                    <exclude reference="1397"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact">
                                                <mask key="constraints">
                                                    <include reference="1396"/>
                                                    <include reference="1397"/>
                                                </mask>
                                            </variation>
                                        </imageView>
                                        <imageView clipsSubviews="YES" userInteractionEnabled="NO" contentMode="scaleAspectFit" horizontalHuggingPriority="251" verticalHuggingPriority="251" image="clock_icon.png" translatesAutoresizingMaskIntoConstraints="NO" id="5BD-Uw-Ob3" misplaced="YES">
                                            <rect key="frame" x="20" y="45" width="40" height="40"/>
                                            <constraints>
                                                <constraint firstAttribute="width" constant="40" id="QNT-3g-kMb"/>
                                            </constraints>
                                        </imageView>
                                        <label opaque="NO" userInteractionEnabled="NO" contentMode="scaleAspectFit" semanticContentAttribute="forceLeftToRight" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="200" textAlignment="justified" lineBreakMode="clip" numberOfLines="0" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="BvQ-eb-G9W" misplaced="YES">
                                            <rect key="frame" x="58" y="48" width="78" height="34"/>
                                            <constraints>
                                                <constraint firstAttribute="width" constant="78" id="z5s-Ig-Xaw"/>
                                            </constraints>
                                            <fontDescription key="fontDescription" name="HelveticaNeue-Bold" family="Helvetica Neue" pointSize="28"/>
                                            <color key="textColor" red="0.88014918565750122" green="0.19283762574195862" blue="0.48432677984237671" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <nil key="highlightedColor"/>
                                        </label>
                                        <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="YOUR POSTS" textAlignment="center" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="DnG-ys-Waw" misplaced="YES">
                                            <rect key="frame" x="0.0" y="262" width="375" height="21"/>
                                            <constraints>
                                                <constraint firstAttribute="height" constant="21" id="1399"/>
                                                <constraint firstAttribute="width" constant="375" id="1400"/>
                                            </constraints>
                                            <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                            <color key="textColor" red="0.0" green="0.0" blue="0.0" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <nil key="highlightedColor"/>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="1399"/>
                                                    <exclude reference="1400"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact">
                                                <mask key="constraints">
                                                    <include reference="1399"/>
                                                    <include reference="1400"/>
                                                </mask>
                                            </variation>
                                        </label>
                                        <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="HOURS GIVEN" textAlignment="center" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="kFG-u5-vod" misplaced="YES">
                                            <rect key="frame" x="29" y="80" width="70" height="12"/>
                                            <fontDescription key="fontDescription" type="system" pointSize="10"/>
                                            <color key="textColor" red="0.33333333333333331" green="0.33333333333333331" blue="0.33333333333333331" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <nil key="highlightedColor"/>
                                        </label>
                                        <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" usesAttributedText="YES" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="XuZ-ur-2WM" userLabel="lblLocation" misplaced="YES">
                                            <rect key="frame" x="82" y="0.0" width="245" height="13"/>
                                            <attributedString key="attributedText">
                                                <fragment content="Engaged, NB, Canada">
                                                    <attributes>
                                                        <color key="NSColor" white="1" alpha="1" colorSpace="custom" customColorSpace="genericGamma22GrayColorSpace"/>
                                                        <font key="NSFont" size="11" name="HelveticaNeue"/>
                                                        <paragraphStyle key="NSParagraphStyle" alignment="natural" lineBreakMode="wordWrapping" baseWritingDirection="natural" tighteningFactorForTruncation="0.0"/>
                                                    </attributes>
                                                </fragment>
                                            </attributedString>
                                            <nil key="highlightedColor"/>
                                        </label>
                                    </subviews>
                                    <color key="backgroundColor" red="0.0" green="0.0" blue="0.0" alpha="0.0" colorSpace="custom" customColorSpace="sRGB"/>
                                    <constraints>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" id="1384"/>
                                        <constraint firstItem="OD3-hj-TeA" firstAttribute="top" secondItem="tTy-rb-KlI" secondAttribute="bottom" constant="5" id="1387"/>
                                        <constraint firstItem="OD3-hj-TeA" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" constant="36" id="1390"/>
                                        <constraint firstAttribute="trailing" secondItem="OD3-hj-TeA" secondAttribute="trailing" constant="28" id="1391"/>
                                        <constraint firstItem="bFU-7W-h1D" firstAttribute="centerY" secondItem="OD3-hj-TeA" secondAttribute="centerY" id="1394"/>
                                        <constraint firstItem="Fsu-9x-aHs" firstAttribute="centerY" secondItem="OD3-hj-TeA" secondAttribute="centerY" id="1395"/>
                                        <constraint firstItem="DnG-ys-Waw" firstAttribute="top" secondItem="OD3-hj-TeA" secondAttribute="bottom" constant="8" id="1398"/>
                                        <constraint firstItem="DnG-ys-Waw" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" id="1401"/>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" id="0JJ-PT-we4"/>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="top" secondItem="5BD-Uw-Ob3" secondAttribute="bottom" constant="15" id="3tm-zm-Bgr"/>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="leading" secondItem="DnG-ys-Waw" secondAttribute="leading" id="4Ed-gK-h5o"/>
                                        <constraint firstAttribute="trailing" secondItem="tTy-rb-KlI" secondAttribute="trailing" id="7kh-jU-vpV"/>
                                        <constraint firstItem="efo-1p-QSX" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leadingMargin" id="8yP-OJ-xsZ"/>
                                        <constraint firstItem="XuZ-ur-2WM" firstAttribute="top" secondItem="krC-UU-cB7" secondAttribute="top" id="AhT-6a-sfv"/>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="trailing" secondItem="Fsu-9x-aHs" secondAttribute="trailing" id="Lro-gs-2S3"/>
                                        <constraint firstItem="BvQ-eb-G9W" firstAttribute="centerY" secondItem="5BD-Uw-Ob3" secondAttribute="centerY" id="NQl-Ga-bi2"/>
                                        <constraint firstItem="efo-1p-QSX" firstAttribute="top" secondItem="Fsu-9x-aHs" secondAttribute="bottom" constant="8" symbolic="YES" id="OAg-fa-duO"/>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="top" secondItem="BvQ-eb-G9W" secondAttribute="bottom" constant="18" id="RFm-5G-1c8"/>
                                        <constraint firstItem="bFU-7W-h1D" firstAttribute="leading" secondItem="efo-1p-QSX" secondAttribute="leading" id="Rce-lC-yZq"/>
                                        <constraint firstItem="OD3-hj-TeA" firstAttribute="top" secondItem="tTy-rb-KlI" secondAttribute="bottom" constant="5" id="Sk9-Rp-Yw3"/>
                                        <constraint firstItem="Fsu-9x-aHs" firstAttribute="trailing" secondItem="DnG-ys-Waw" secondAttribute="trailing" id="V3R-kw-SAI"/>
                                        <constraint firstItem="efo-1p-QSX" firstAttribute="centerX" secondItem="DnG-ys-Waw" secondAttribute="centerX" id="Vra-MP-boB"/>
                                        <constraint firstItem="efo-1p-QSX" firstAttribute="top" secondItem="krC-UU-cB7" secondAttribute="top" constant="212" id="ZS6-vJ-DEP"/>
                                        <constraint firstItem="DnG-ys-Waw" firstAttribute="top" secondItem="OD3-hj-TeA" secondAttribute="bottom" constant="8" symbolic="YES" id="a5L-7v-ktS"/>
                                        <constraint firstAttribute="bottom" secondItem="DnG-ys-Waw" secondAttribute="bottom" id="agY-UZ-dsP"/>
                                        <constraint firstItem="5BD-Uw-Ob3" firstAttribute="top" secondItem="krC-UU-cB7" secondAttribute="top" constant="45" id="axY-G2-65q"/>
                                        <constraint firstItem="tTy-rb-KlI" firstAttribute="top" secondItem="kFG-u5-vod" secondAttribute="bottom" constant="8" symbolic="YES" id="axz-wr-jSO"/>
                                        <constraint firstItem="kFG-u5-vod" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" constant="29" id="dRg-8f-156"/>
                                        <constraint firstItem="BvQ-eb-G9W" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" constant="58" id="fLq-HQ-m7K"/>
                                        <constraint firstItem="Fsu-9x-aHs" firstAttribute="leading" secondItem="OD3-hj-TeA" secondAttribute="trailing" id="gQt-en-cJs"/>
                                        <constraint firstAttribute="trailing" secondItem="XuZ-ur-2WM" secondAttribute="trailing" constant="48" id="lRf-Gi-BqN"/>
                                        <constraint firstItem="5BD-Uw-Ob3" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" constant="20" id="ohI-UA-1Kk"/>
                                        <constraint firstItem="efo-1p-QSX" firstAttribute="top" secondItem="bFU-7W-h1D" secondAttribute="bottom" constant="8" symbolic="YES" id="rGn-nJ-SUx"/>
                                        <constraint firstItem="OD3-hj-TeA" firstAttribute="centerY" secondItem="Fsu-9x-aHs" secondAttribute="centerY" id="sPM-5a-OMR"/>
                                        <constraint firstItem="XuZ-ur-2WM" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" constant="82" id="u4b-RX-wCM"/>
                                        <constraint firstItem="DnG-ys-Waw" firstAttribute="top" secondItem="efo-1p-QSX" secondAttribute="bottom" constant="14" id="ulJ-32-boq"/>
                                        <constraint firstItem="OD3-hj-TeA" firstAttribute="leading" secondItem="krC-UU-cB7" secondAttribute="leading" constant="36" id="wDh-3D-sj3"/>
                                    </constraints>
                                    <variation key="default">
                                        <mask key="subviews">
                                            <exclude reference="tTy-rb-KlI"/>
                                            <exclude reference="efo-1p-QSX"/>
                                            <exclude reference="5BD-Uw-Ob3"/>
                                            <exclude reference="DnG-ys-Waw"/>
                                            <exclude reference="kFG-u5-vod"/>
                                        </mask>
                                        <mask key="constraints">
                                            <exclude reference="1384"/>
                                            <exclude reference="1398"/>
                                            <exclude reference="1401"/>
                                            <exclude reference="1387"/>
                                            <exclude reference="1390"/>
                                            <exclude reference="1391"/>
                                            <exclude reference="1394"/>
                                            <exclude reference="1395"/>
                                        </mask>
                                    </variation>
                                    <variation key="heightClass=regular-widthClass=compact">
                                        <mask key="subviews">
                                            <include reference="tTy-rb-KlI"/>
                                            <include reference="efo-1p-QSX"/>
                                            <include reference="5BD-Uw-Ob3"/>
                                            <include reference="BvQ-eb-G9W"/>
                                            <include reference="DnG-ys-Waw"/>
                                            <include reference="kFG-u5-vod"/>
                                        </mask>
                                        <mask key="constraints">
                                            <include reference="1384"/>
                                            <include reference="1398"/>
                                            <include reference="1401"/>
                                            <include reference="1387"/>
                                            <include reference="1390"/>
                                            <include reference="1391"/>
                                            <include reference="1394"/>
                                            <include reference="1395"/>
                                        </mask>
                                    </variation>
                                    <variation key="heightClass=regular-widthClass=regular">
                                        <mask key="subviews">
                                            <include reference="tTy-rb-KlI"/>
                                            <include reference="efo-1p-QSX"/>
                                            <include reference="DnG-ys-Waw"/>
                                            <include reference="kFG-u5-vod"/>
                                        </mask>
                                    </variation>
                                </scrollView>
                            </tableView>
                            <view contentMode="scaleAspectFit" translatesAutoresizingMaskIntoConstraints="NO" id="DAl-Jw-82j" userLabel="HeaderBackgroundHeader">
                                <rect key="frame" x="1" y="2" width="374" height="65"/>
                                <subviews>
                                    <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="p4O-Ye-rUu" userLabel="HeaderDetailsContainer">
                                        <rect key="frame" x="-7" y="-6" width="373" height="114"/>
                                        <subviews>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" usesAttributedText="YES" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" minimumFontSize="12" translatesAutoresizingMaskIntoConstraints="NO" id="Maw-VX-LOb" userLabel="lblEmployeeName">
                                                <rect key="frame" x="124" y="24" width="237" height="24"/>
                                                <constraints>
                                                    <constraint firstAttribute="width" constant="237" id="hyW-Zw-gcr"/>
                                                </constraints>
                                                <attributedString key="attributedText">
                                                    <fragment content="Sally Legend">
                                                        <attributes>
                                                            <color key="NSColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                                            <font key="NSFont" size="20" name="HelveticaNeue-Bold"/>
                                                            <paragraphStyle key="NSParagraphStyle" alignment="natural" lineBreakMode="truncatingTail" baseWritingDirection="natural" tighteningFactorForTruncation="0.0"/>
                                                        </attributes>
                                                    </fragment>
                                                </attributedString>
                                                <nil key="highlightedColor"/>
                                                <variation key="heightClass=regular-widthClass=regular">
                                                    <fontDescription key="fontDescription" name="HelveticaNeue" family="Helvetica Neue" pointSize="17"/>
                                                </variation>
                                            </label>
                                            <imageView userInteractionEnabled="NO" contentMode="scaleToFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" translatesAutoresizingMaskIntoConstraints="NO" id="gMK-Ue-eTg">
                                                <rect key="frame" x="16" y="13" width="100" height="100"/>
                                                <constraints>
                                                    <constraint firstAttribute="height" constant="100" id="1340"/>
                                                    <constraint firstAttribute="width" constant="100" id="1341"/>
                                                </constraints>
                                                <variation key="default">
                                                    <mask key="constraints">
                                                        <exclude reference="1340"/>
                                                        <exclude reference="1341"/>
                                                    </mask>
                                                </variation>
                                                <variation key="heightClass=regular-widthClass=compact">
                                                    <mask key="constraints">
                                                        <include reference="1340"/>
                                                        <include reference="1341"/>
                                                    </mask>
                                                </variation>
                                            </imageView>
                                            <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" usesAttributedText="YES" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="AMa-Ew-dw4" userLabel="lblLocation">
                                                <rect key="frame" x="124" y="49" width="245" height="13"/>
                                                <attributedString key="attributedText">
                                                    <fragment content="Engaged, NB, Canada">
                                                        <attributes>
                                                            <color key="NSColor" white="1" alpha="1" colorSpace="custom" customColorSpace="genericGamma22GrayColorSpace"/>
                                                            <font key="NSFont" size="11" name="HelveticaNeue"/>
                                                            <paragraphStyle key="NSParagraphStyle" alignment="natural" lineBreakMode="wordWrapping" baseWritingDirection="natural" tighteningFactorForTruncation="0.0"/>
                                                        </attributes>
                                                    </fragment>
                                                </attributedString>
                                                <nil key="highlightedColor"/>
                                            </label>
                                        </subviews>
                                        <constraints>
                                            <constraint firstItem="gMK-Ue-eTg" firstAttribute="leading" secondItem="p4O-Ye-rUu" secondAttribute="leading" constant="16" id="1342"/>
                                            <constraint firstAttribute="width" constant="373" id="1363"/>
                                            <constraint firstAttribute="height" constant="114" id="1364"/>
                                            <constraint firstItem="gMK-Ue-eTg" firstAttribute="top" secondItem="p4O-Ye-rUu" secondAttribute="top" constant="13" id="0Q5-Nj-i5b"/>
                                            <constraint firstItem="AMa-Ew-dw4" firstAttribute="leading" secondItem="Maw-VX-LOb" secondAttribute="leading" id="0Sg-k2-SZj"/>
                                            <constraint firstItem="Maw-VX-LOb" firstAttribute="leading" secondItem="gMK-Ue-eTg" secondAttribute="trailing" constant="8" symbolic="YES" id="Iml-NA-c04"/>
                                            <constraint firstAttribute="bottom" secondItem="gMK-Ue-eTg" secondAttribute="bottom" constant="1" id="Nl9-cp-Zeh"/>
                                            <constraint firstAttribute="trailing" secondItem="Maw-VX-LOb" secondAttribute="trailing" constant="12" id="QGn-Yi-59n"/>
                                            <constraint firstAttribute="bottom" secondItem="AMa-Ew-dw4" secondAttribute="bottom" constant="52" id="b1B-7a-YFl"/>
                                            <constraint firstItem="Maw-VX-LOb" firstAttribute="leading" secondItem="gMK-Ue-eTg" secondAttribute="trailing" constant="8" id="bJE-Nz-QvS"/>
                                            <constraint firstItem="AMa-Ew-dw4" firstAttribute="top" secondItem="Maw-VX-LOb" secondAttribute="bottom" constant="1" id="boY-Pu-LTf"/>
                                            <constraint firstItem="Maw-VX-LOb" firstAttribute="leading" secondItem="gMK-Ue-eTg" secondAttribute="trailing" constant="8" symbolic="YES" id="hrh-IO-tZq"/>
                                            <constraint firstAttribute="trailing" secondItem="AMa-Ew-dw4" secondAttribute="trailing" constant="4" id="ito-6s-a3G"/>
                                            <constraint firstItem="gMK-Ue-eTg" firstAttribute="leading" secondItem="p4O-Ye-rUu" secondAttribute="leading" constant="16" id="kCk-sU-Y6a"/>
                                            <constraint firstItem="Maw-VX-LOb" firstAttribute="top" secondItem="p4O-Ye-rUu" secondAttribute="top" constant="24" id="zuu-Ui-fHI"/>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="subviews">
                                                <exclude reference="Maw-VX-LOb"/>
                                                <exclude reference="AMa-Ew-dw4"/>
                                            </mask>
                                            <mask key="constraints">
                                                <exclude reference="1363"/>
                                                <exclude reference="1364"/>
                                                <exclude reference="1342"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="subviews">
                                                <include reference="Maw-VX-LOb"/>
                                                <include reference="AMa-Ew-dw4"/>
                                            </mask>
                                            <mask key="constraints">
                                                <include reference="1363"/>
                                                <include reference="1364"/>
                                                <include reference="1342"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="subviews">
                                                <include reference="Maw-VX-LOb"/>
                                                <include reference="AMa-Ew-dw4"/>
                                            </mask>
                                        </variation>
                                    </view>
                                </subviews>
                                <color key="backgroundColor" red="0.38431372549999998" green="0.83921568629999999" blue="0.89411764709999997" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="height" constant="65" id="1360"/>
                                    <constraint firstItem="p4O-Ye-rUu" firstAttribute="top" secondItem="DAl-Jw-82j" secondAttribute="top" constant="-6" id="041-sx-ptq"/>
                                    <constraint firstItem="p4O-Ye-rUu" firstAttribute="trailing" secondItem="DAl-Jw-82j" secondAttribute="trailingMargin" id="NFx-Bv-kxO"/>
                                    <constraint firstAttribute="bottom" secondItem="p4O-Ye-rUu" secondAttribute="bottom" constant="-43" id="Qnu-eG-fS2"/>
                                    <constraint firstItem="p4O-Ye-rUu" firstAttribute="leading" secondItem="DAl-Jw-82j" secondAttribute="leading" constant="-7" id="pGR-KH-Ckj"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="constraints">
                                        <exclude reference="1360"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="constraints">
                                        <include reference="1360"/>
                                    </mask>
                                </variation>
                            </view>
                        </subviews>
                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstAttribute="trailing" secondItem="JPD-6D-js7" secondAttribute="trailing" id="762"/>
                            <constraint firstAttribute="bottom" secondItem="JPD-6D-js7" secondAttribute="bottom" id="763"/>
                            <constraint firstItem="nuy-vl-gIN" firstAttribute="bottom" secondItem="c6H-0P-Zmz" secondAttribute="top" id="242-Ft-ggs"/>
                            <constraint firstItem="nuy-vl-gIN" firstAttribute="top" secondItem="DAl-Jw-82j" secondAttribute="bottom" id="6FS-qF-ZHe"/>
                            <constraint firstItem="JPD-6D-js7" firstAttribute="leading" secondItem="7lR-R9-aiK" secondAttribute="leading" id="7VF-sm-zLV"/>
                            <constraint firstItem="JPD-6D-js7" firstAttribute="top" secondItem="7lR-R9-aiK" secondAttribute="top" id="8ya-gw-6Fa"/>
                            <constraint firstItem="DAl-Jw-82j" firstAttribute="centerX" secondItem="nuy-vl-gIN" secondAttribute="centerX" id="Gpr-oZ-3mm"/>
                            <constraint firstItem="DAl-Jw-82j" firstAttribute="top" secondItem="7lR-R9-aiK" secondAttribute="topMargin" constant="2" id="Rvw-5Z-oBx"/>
                            <constraint firstItem="JPD-6D-js7" firstAttribute="bottom" secondItem="nuy-vl-gIN" secondAttribute="bottom" id="ZL3-J0-o21"/>
                            <constraint firstItem="nuy-vl-gIN" firstAttribute="trailing" secondItem="JPD-6D-js7" secondAttribute="trailing" id="dBb-5j-X6v"/>
                            <constraint firstItem="DAl-Jw-82j" firstAttribute="trailing" secondItem="nuy-vl-gIN" secondAttribute="trailing" id="lUC-wb-Xu7"/>
                            <constraint firstItem="nuy-vl-gIN" firstAttribute="leading" secondItem="JPD-6D-js7" secondAttribute="leading" id="uZV-kx-JAr"/>
                        </constraints>
                        <variation key="default">
                            <mask key="subviews">
                                <exclude reference="DAl-Jw-82j"/>
                            </mask>
                            <mask key="constraints">
                                <exclude reference="762"/>
                                <exclude reference="763"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=compact">
                            <mask key="subviews">
                                <include reference="DAl-Jw-82j"/>
                            </mask>
                            <mask key="constraints">
                                <include reference="762"/>
                                <include reference="763"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=regular">
                            <mask key="subviews">
                                <include reference="DAl-Jw-82j"/>
                            </mask>
                        </variation>
                    </view>
                    <connections>
                        <outlet property="ActivityScrollView" destination="krC-UU-cB7" id="kAe-h7-anr"/>
                        <outlet property="ClockIcon" destination="5BD-Uw-Ob3" id="Mpf-E4-oO4"/>
                        <outlet property="EmployeeName" destination="Maw-VX-LOb" id="Jgk-4q-CgP"/>
                        <outlet property="GoalsScrollView" destination="OD3-hj-TeA" id="8nA-eA-84j"/>
                        <outlet property="HeaderBackground" destination="DAl-Jw-82j" id="1VB-dH-TSf"/>
                        <outlet property="HeaderDetailsContainer" destination="p4O-Ye-rUu" id="rCM-pc-Hze"/>
                        <outlet property="LatestPostTableView" destination="nuy-vl-gIN" id="03h-xk-LQI"/>
                        <outlet property="LeftArrow" destination="bFU-7W-h1D" id="hci-af-44y"/>
                        <outlet property="Location" destination="AMa-Ew-dw4" id="XCd-tT-huX"/>
                        <outlet property="Overlay" destination="JPD-6D-js7" id="Wod-1n-b6d"/>
                        <outlet property="ProfilePicture" destination="gMK-Ue-eTg" id="ziw-51-VOs"/>
                        <outlet property="RightArrow" destination="Fsu-9x-aHs" id="3FH-4z-X42"/>
                        <outlet property="lblGoals" destination="tTy-rb-KlI" id="LMA-WQ-Dqd"/>
                        <outlet property="lblHourAmount" destination="BvQ-eb-G9W" id="HPm-Ml-3ZI"/>
                        <outlet property="lblHoursGiven" destination="kFG-u5-vod" id="tXR-rb-iqj"/>
                        <outlet property="lblLatest" destination="DnG-ys-Waw" id="5m3-oy-aif"/>
                        <outlet property="waiting" destination="RnJ-ie-tZ2" id="sHy-YZ-8wf"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="m7G-QW-1Ey" userLabel="First Responder" sceneMemberID="firstResponder"/>
                <tapGestureRecognizer id="iHq-ve-yqJ"/>
            </objects>
            <point key="canvasLocation" x="960.2" y="-9.379303"/>
        </scene>
        <!--Account Settings View Controller-->
        <scene sceneID="NwV-ur-c4n">
            <objects>
                <viewController storyboardIdentifier="AccountSettingsViewController" id="xrz-t6-VIi" userLabel="Account Settings View Controller" customClass="AccountSettingsViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="pCs-yf-oed"/>
                        <viewControllerLayoutGuide type="bottom" id="IgX-8A-dK9"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="rFr-Ck-LgV">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <webView contentMode="scaleToFill" scalesPageToFit="YES" allowsInlineMediaPlayback="NO" translatesAutoresizingMaskIntoConstraints="NO" id="LEw-Vg-NQz">
                                <rect key="frame" x="0.0" y="20" width="375" height="647"/>
                                <color key="backgroundColor" red="0.28958413004875183" green="0.31462949514389038" blue="0.32950475811958313" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <dataDetectorType key="dataDetectorTypes"/>
                            </webView>
                        </subviews>
                        <color key="backgroundColor" red="0.27450980390000002" green="0.71372549019999998" blue="0.74117647060000003" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstItem="LEw-Vg-NQz" firstAttribute="top" secondItem="rFr-Ck-LgV" secondAttribute="topMargin" id="FTj-UF-5GD">
                                <variation key="heightClass=regular-widthClass=compact" constant="20"/>
                            </constraint>
                            <constraint firstItem="LEw-Vg-NQz" firstAttribute="centerX" secondItem="rFr-Ck-LgV" secondAttribute="centerX" id="J4i-m1-NxA"/>
                            <constraint firstItem="IgX-8A-dK9" firstAttribute="top" secondItem="LEw-Vg-NQz" secondAttribute="bottom" id="VBi-MI-Dhh"/>
                            <constraint firstItem="LEw-Vg-NQz" firstAttribute="width" secondItem="rFr-Ck-LgV" secondAttribute="width" id="X88-JJ-RsH"/>
                        </constraints>
                        <variation key="default">
                            <mask key="subviews">
                                <exclude reference="LEw-Vg-NQz"/>
                            </mask>
                            <mask key="constraints">
                                <exclude reference="VBi-MI-Dhh"/>
                                <exclude reference="FTj-UF-5GD"/>
                                <exclude reference="J4i-m1-NxA"/>
                                <exclude reference="X88-JJ-RsH"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=compact">
                            <mask key="subviews">
                                <include reference="LEw-Vg-NQz"/>
                            </mask>
                            <mask key="constraints">
                                <include reference="VBi-MI-Dhh"/>
                                <include reference="FTj-UF-5GD"/>
                                <include reference="J4i-m1-NxA"/>
                                <include reference="X88-JJ-RsH"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=regular">
                            <mask key="subviews">
                                <include reference="LEw-Vg-NQz"/>
                            </mask>
                            <mask key="constraints">
                                <include reference="VBi-MI-Dhh"/>
                                <include reference="FTj-UF-5GD"/>
                                <include reference="J4i-m1-NxA"/>
                            </mask>
                        </variation>
                    </view>
                    <connections>
                        <outlet property="AccountSettingsWebView" destination="LEw-Vg-NQz" id="leN-Bm-yGm"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="pdh-ll-sNt" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="-96.5" y="2005.75"/>
        </scene>
        <!--Home View Controller-->
        <scene sceneID="JMT-C1-rac">
            <objects>
                <tabBarController storyboardIdentifier="HomeViewController" id="lTr-3H-jJa" customClass="HomeViewController" sceneMemberID="viewController">
                    <tabBar key="tabBar" contentMode="scaleToFill" translucent="NO" id="oyR-XI-SnW">
                        <rect key="frame" x="0.0" y="551" width="600" height="49"/>
                        <autoresizingMask key="autoresizingMask"/>
                        <color key="barTintColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <color key="selectedImageTintColor" red="0.88014918565750122" green="0.19283762574195862" blue="0.48432677984237671" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                    </tabBar>
                </tabBarController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="eSP-Ui-Gnl" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="938" y="1335"/>
        </scene>
        <!--Activity View Controller-->
        <scene sceneID="LK5-R8-rXY">
            <objects>
                <viewController storyboardIdentifier="ActivityViewController" id="laU-V0-Uae" customClass="ActivityViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="8Un-xC-7kr"/>
                        <viewControllerLayoutGuide type="bottom" id="VOX-om-erd"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="y9F-4I-Yms">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="yHf-5B-Hu6" userLabel="Overlay" misplaced="YES">
                                <rect key="frame" x="0.0" y="0.0" width="375" height="667"/>
                                <subviews>
                                    <activityIndicatorView opaque="NO" contentMode="scaleToFill" horizontalHuggingPriority="750" verticalHuggingPriority="750" animating="YES" style="gray" translatesAutoresizingMaskIntoConstraints="NO" id="lA0-S9-ZLz" userLabel="Waiting">
                                        <rect key="frame" x="178" y="324" width="20" height="20"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="20" id="KZu-cA-o7K">
                                                <variation key="heightClass=regular-widthClass=regular" constant="40"/>
                                            </constraint>
                                            <constraint firstAttribute="height" constant="20" id="wdJ-KN-MOq">
                                                <variation key="heightClass=regular-widthClass=regular" constant="40"/>
                                            </constraint>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="KZu-cA-o7K"/>
                                                <exclude reference="wdJ-KN-MOq"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="KZu-cA-o7K"/>
                                                <include reference="wdJ-KN-MOq"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=regular">
                                            <mask key="constraints">
                                                <include reference="KZu-cA-o7K"/>
                                                <include reference="wdJ-KN-MOq"/>
                                            </mask>
                                        </variation>
                                    </activityIndicatorView>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="0.74528556030000004" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="trailing" secondItem="lA0-S9-ZLz" secondAttribute="trailing" constant="177" id="1224"/>
                                    <constraint firstAttribute="bottom" secondItem="lA0-S9-ZLz" secondAttribute="bottom" constant="323" id="1225"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="subviews">
                                        <exclude reference="lA0-S9-ZLz"/>
                                    </mask>
                                    <mask key="constraints">
                                        <exclude reference="1224"/>
                                        <exclude reference="1225"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="lA0-S9-ZLz"/>
                                    </mask>
                                    <mask key="constraints">
                                        <include reference="1224"/>
                                        <include reference="1225"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=regular">
                                    <mask key="subviews">
                                        <include reference="lA0-S9-ZLz"/>
                                    </mask>
                                </variation>
                            </view>
                            <tableView clipsSubviews="YES" contentMode="scaleAspectFit" preservesSuperviewLayoutMargins="YES" directionalLockEnabled="YES" showsHorizontalScrollIndicator="NO" showsVerticalScrollIndicator="NO" dataMode="prototypes" style="plain" separatorStyle="none" rowHeight="44" sectionHeaderHeight="28" sectionFooterHeight="28" translatesAutoresizingMaskIntoConstraints="NO" id="DcZ-bc-Zc3" userLabel="CompanyActivity">
                                <rect key="frame" x="0.0" y="20" width="375" height="548"/>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="width" relation="greaterThanOrEqual" constant="320" id="1268"/>
                                    <constraint firstAttribute="height" constant="548" id="1269"/>
                                </constraints>
                                <color key="separatorColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <inset key="separatorInset" minX="0.0" minY="0.0" maxX="0.0" maxY="0.0"/>
                                <variation key="default">
                                    <mask key="constraints">
                                        <exclude reference="1268"/>
                                        <exclude reference="1269"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="constraints">
                                        <include reference="1268"/>
                                        <include reference="1269"/>
                                    </mask>
                                </variation>
                            </tableView>
                        </subviews>
                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstAttribute="trailing" secondItem="DcZ-bc-Zc3" secondAttribute="trailing" id="1266"/>
                            <constraint firstAttribute="bottom" secondItem="DcZ-bc-Zc3" secondAttribute="bottom" id="1267"/>
                            <constraint firstItem="DcZ-bc-Zc3" firstAttribute="top" secondItem="8Un-xC-7kr" secondAttribute="bottom" id="1270"/>
                            <constraint firstItem="yHf-5B-Hu6" firstAttribute="bottom" secondItem="VOX-om-erd" secondAttribute="top" id="4Pn-f5-ONt"/>
                            <constraint firstItem="yHf-5B-Hu6" firstAttribute="top" secondItem="y9F-4I-Yms" secondAttribute="top" id="Y4c-vi-hvR"/>
                            <constraint firstItem="yHf-5B-Hu6" firstAttribute="leading" secondItem="y9F-4I-Yms" secondAttribute="leading" id="bd6-0s-IzH"/>
                            <constraint firstItem="DcZ-bc-Zc3" firstAttribute="leading" secondItem="yHf-5B-Hu6" secondAttribute="leading" id="fC3-nu-mJa"/>
                            <constraint firstAttribute="trailing" secondItem="yHf-5B-Hu6" secondAttribute="trailing" id="gLd-uj-gaH"/>
                        </constraints>
                        <variation key="default">
                            <mask key="subviews">
                                <exclude reference="yHf-5B-Hu6"/>
                            </mask>
                            <mask key="constraints">
                                <exclude reference="1266"/>
                                <exclude reference="1267"/>
                                <exclude reference="1270"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=compact">
                            <mask key="subviews">
                                <include reference="yHf-5B-Hu6"/>
                            </mask>
                            <mask key="constraints">
                                <include reference="1266"/>
                                <include reference="1267"/>
                                <include reference="1270"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=regular">
                            <mask key="subviews">
                                <include reference="yHf-5B-Hu6"/>
                            </mask>
                        </variation>
                    </view>
                    <connections>
                        <outlet property="CompanyActivityTableView" destination="DcZ-bc-Zc3" id="tGu-v0-1jF"/>
                        <outlet property="Overlay" destination="yHf-5B-Hu6" id="WHY-Xk-0rb"/>
                        <outlet property="Waiting" destination="lA0-S9-ZLz" id="yiy-lv-zwM"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="KhJ-fH-Euc" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="1812.875" y="908.5211"/>
        </scene>
        <!--Log Hour Photo View Controller-->
        <scene sceneID="1429">
            <objects>
                <viewController storyboardIdentifier="LogHourPhotoViewController" id="1430" customClass="LogHourPhotoViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="1510"/>
                        <viewControllerLayoutGuide type="bottom" id="1511"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="1530">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                        <subviews>
                            <view contentMode="scaleToFill" placeholderIntrinsicWidth="375" placeholderIntrinsicHeight="67" translatesAutoresizingMaskIntoConstraints="NO" id="1569" customClass="PorpoiseView" misplaced="YES">
                                <rect key="frame" x="0.0" y="0.0" width="375" height="67"/>
                                <subviews>
                                    <imageView userInteractionEnabled="NO" contentMode="scaleAspectFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" image="LogPostPhotoHeaderBackground.png" translatesAutoresizingMaskIntoConstraints="NO" id="Vz4-q1-cB4" misplaced="YES">
                                        <rect key="frame" x="-10" y="0.0" width="393" height="59"/>
                                    </imageView>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" fixedFrame="YES" text="Select the photo you want to post" textAlignment="center" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="1602">
                                        <rect key="frame" x="0.0" y="23" width="375" height="21"/>
                                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                                        <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                        <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                </subviews>
                                <color key="backgroundColor" red="0.94440215826034546" green="0.16252747178077698" blue="0.057033799588680267" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstItem="Vz4-q1-cB4" firstAttribute="top" secondItem="1569" secondAttribute="top" id="Yda-t4-ItF"/>
                                    <constraint firstAttribute="trailing" secondItem="Vz4-q1-cB4" secondAttribute="trailing" constant="-8" id="deO-P0-qia"/>
                                    <constraint firstItem="Vz4-q1-cB4" firstAttribute="bottom" secondItem="1569" secondAttribute="bottomMargin" id="hNu-tw-nuQ"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="subviews">
                                        <exclude reference="1602"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="1602"/>
                                    </mask>
                                </variation>
                            </view>
                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="1576" misplaced="YES">
                                <rect key="frame" x="0.0" y="102" width="375" height="566"/>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                            </view>
                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="1610" misplaced="YES">
                                <rect key="frame" x="0.0" y="67" width="375" height="35"/>
                                <subviews>
                                    <button opaque="NO" contentMode="scaleToFill" fixedFrame="YES" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="1632">
                                        <rect key="frame" x="0.0" y="0.0" width="125" height="30"/>
                                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                                        <state key="normal" title="Camera">
                                            <color key="titleColor" red="0.016804177314043045" green="0.19835099577903748" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <color key="titleShadowColor" red="0.57230675220489502" green="0.57230675220489502" blue="0.57230675220489502" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        </state>
                                    </button>
                                    <button opaque="NO" contentMode="scaleToFill" fixedFrame="YES" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="1638">
                                        <rect key="frame" x="125" y="2" width="125" height="30"/>
                                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                                        <state key="normal" title="Gallery">
                                            <color key="titleColor" red="0.016804177314043045" green="0.19835099577903748" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <color key="titleShadowColor" red="0.57230675220489502" green="0.57230675220489502" blue="0.57230675220489502" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        </state>
                                    </button>
                                    <button opaque="NO" contentMode="scaleToFill" fixedFrame="YES" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="1647">
                                        <rect key="frame" x="250" y="2" width="125" height="30"/>
                                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                                        <state key="normal" title="No Photo">
                                            <color key="titleColor" red="0.016804177314043045" green="0.19835099577903748" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <color key="titleShadowColor" red="0.57230675220489502" green="0.57230675220489502" blue="0.57230675220489502" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        </state>
                                    </button>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <variation key="default">
                                    <mask key="subviews">
                                        <exclude reference="1632"/>
                                        <exclude reference="1638"/>
                                        <exclude reference="1647"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="1632"/>
                                        <include reference="1638"/>
                                        <include reference="1647"/>
                                    </mask>
                                </variation>
                            </view>
                        </subviews>
                        <color key="backgroundColor" white="1" alpha="1" colorSpace="calibratedWhite"/>
                        <constraints>
                            <constraint firstItem="1576" firstAttribute="top" secondItem="1610" secondAttribute="bottom" id="4Yo-1x-wdU"/>
                            <constraint firstItem="1610" firstAttribute="top" secondItem="1569" secondAttribute="bottom" id="HJH-lU-6Ru"/>
                            <constraint firstItem="1569" firstAttribute="top" secondItem="1530" secondAttribute="top" id="IdM-vx-EBF"/>
                            <constraint firstItem="1569" firstAttribute="leading" secondItem="1576" secondAttribute="leading" id="SVo-7F-wAw"/>
                            <constraint firstItem="1576" firstAttribute="top" secondItem="1569" secondAttribute="bottom" constant="35" id="UHh-cm-VWC"/>
                            <constraint firstAttribute="bottomMargin" secondItem="1576" secondAttribute="bottom" constant="-1" id="dnq-T9-7mA"/>
                            <constraint firstAttribute="bottom" secondItem="1610" secondAttribute="bottom" constant="565" id="fEQ-Mx-J7O"/>
                            <constraint firstItem="1569" firstAttribute="leading" secondItem="1530" secondAttribute="leading" id="fd9-5M-2SZ"/>
                            <constraint firstItem="1569" firstAttribute="trailing" secondItem="1610" secondAttribute="trailing" id="hbx-61-td5"/>
                            <constraint firstItem="1569" firstAttribute="leading" secondItem="1610" secondAttribute="leading" id="l8U-O0-Ef4"/>
                            <constraint firstAttribute="trailing" secondItem="1569" secondAttribute="trailing" id="pil-D6-BOQ"/>
                            <constraint firstAttribute="bottom" secondItem="1569" secondAttribute="bottom" constant="600" id="sT0-WX-MFs"/>
                            <constraint firstItem="1569" firstAttribute="trailing" secondItem="1576" secondAttribute="trailing" id="vAK-ht-69a"/>
                        </constraints>
                        <variation key="default">
                            <mask key="subviews">
                                <exclude reference="1569"/>
                                <exclude reference="1576"/>
                                <exclude reference="1610"/>
                            </mask>
                        </variation>
                        <variation key="heightClass=regular-widthClass=compact">
                            <mask key="subviews">
                                <include reference="1569"/>
                                <include reference="1576"/>
                                <include reference="1610"/>
                            </mask>
                        </variation>
                    </view>
                    <connections>
                        <outlet property="CameraButton" destination="1632" id="name-outlet-1632"/>
                        <outlet property="GalleryButton" destination="1638" id="name-outlet-1638"/>
                        <outlet property="NoPhotoButton" destination="1647" id="name-outlet-1647"/>
                        <outlet property="TopView" destination="1569" id="name-outlet-1569"/>
                        <outlet property="buttons" destination="1610" id="name-outlet-1610"/>
                        <outlet property="mainView" destination="1576" id="name-outlet-1576"/>
                        <outlet property="topViewBackgroundImage" destination="Vz4-q1-cB4" id="name-outlet-Vz4-q1-cB4"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="1432" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="-1128.8" y="2336.951"/>
        </scene>
        <!--Log Post Organization View Controller-->
        <scene sceneID="1728">
            <objects>
                <viewController storyboardIdentifier="LogPostOrganizationViewController" id="1729" customClass="LogPostOrganizationViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="1726"/>
                        <viewControllerLayoutGuide type="bottom" id="1727"/>
                    </layoutGuides>
                    <scrollView key="view" clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" ambiguous="YES" id="1824">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="1825">
                                <rect key="frame" x="0.0" y="0.0" width="375" height="154"/>
                                <subviews>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="What did you contribute?" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2191">
                                        <rect key="frame" x="20" y="33" width="335" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="335" id="2219"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Metric" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2192">
                                        <rect key="frame" x="20" y="66" width="92" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" relation="greaterThanOrEqual" constant="92" id="2222"/>
                                            <constraint firstAttribute="height" constant="21" id="2223"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="11"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Date of activity" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2201">
                                        <rect key="frame" x="219" y="66" width="92" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="92" id="2226"/>
                                            <constraint firstAttribute="height" constant="21" id="2227"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="11"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="0" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="2205">
                                        <rect key="frame" x="20" y="87" width="97" height="30"/>
                                        <color key="tintColor" red="0.0" green="0.0" blue="0.0" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="97" id="2230"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits" keyboardType="decimalPad"/>
                                    </textField>
                                    <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="2206" customClass="PorpoiseEditText">
                                        <rect key="frame" x="215" y="87" width="126" height="30"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="126" id="2629"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits"/>
                                    </textField>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="height" constant="154" id="1828"/>
                                    <constraint firstAttribute="width" constant="375" id="1829"/>
                                    <constraint firstItem="2191" firstAttribute="top" secondItem="1825" secondAttribute="top" constant="33" id="2217"/>
                                    <constraint firstAttribute="trailing" secondItem="2191" secondAttribute="trailing" constant="20" id="2218"/>
                                    <constraint firstItem="2192" firstAttribute="top" secondItem="1825" secondAttribute="top" constant="66" id="2220"/>
                                    <constraint firstItem="2192" firstAttribute="leading" secondItem="1825" secondAttribute="leading" constant="20" id="2221"/>
                                    <constraint firstItem="2201" firstAttribute="top" secondItem="1825" secondAttribute="top" constant="66" id="2224"/>
                                    <constraint firstItem="2205" firstAttribute="leading" secondItem="1825" secondAttribute="leading" constant="20" id="2228"/>
                                    <constraint firstAttribute="bottom" secondItem="2205" secondAttribute="bottom" constant="37" id="2229"/>
                                    <constraint firstAttribute="bottom" secondItem="2206" secondAttribute="bottom" constant="37" id="2231"/>
                                    <constraint firstItem="2206" firstAttribute="leading" secondItem="1825" secondAttribute="leading" constant="215" id="2519"/>
                                    <constraint firstItem="2201" firstAttribute="leading" secondItem="1825" secondAttribute="leading" constant="219" id="2520"/>
                                </constraints>
                            </view>
                            <view contentMode="scaleToFill" translatesAutoresizingMaskIntoConstraints="NO" id="1827">
                                <rect key="frame" x="0.0" y="153" width="375" height="514"/>
                                <subviews>
                                    <imageView clipsSubviews="YES" userInteractionEnabled="NO" contentMode="scaleAspectFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" translatesAutoresizingMaskIntoConstraints="NO" id="1836">
                                        <rect key="frame" x="20" y="28" width="90" height="79"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="90" id="2287"/>
                                            <constraint firstAttribute="height" constant="79" id="2288"/>
                                            <constraint firstAttribute="height" constant="79" id="2386"/>
                                            <constraint firstAttribute="width" constant="90" id="2387"/>
                                        </constraints>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="2287"/>
                                                <exclude reference="2288"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="2287"/>
                                                <include reference="2288"/>
                                            </mask>
                                        </variation>
                                    </imageView>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Tell us about it" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="1843">
                                        <rect key="frame" x="20" y="0.0" width="210" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="height" constant="21" id="1846"/>
                                            <constraint firstAttribute="width" constant="210" id="1847"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <textView clipsSubviews="YES" multipleTouchEnabled="YES" contentMode="scaleToFill" textAlignment="natural" translatesAutoresizingMaskIntoConstraints="NO" id="1868" customClass="PorpoiseTextView">
                                        <rect key="frame" x="115" y="29" width="249" height="78"/>
                                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <color key="tintColor" red="0.0" green="0.0" blue="0.0" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="249" id="1871"/>
                                            <constraint firstAttribute="height" constant="78" id="1872"/>
                                        </constraints>
                                        <color key="textColor" red="0.0" green="0.0" blue="0.0" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits" autocapitalizationType="sentences" returnKeyType="done"/>
                                    </textView>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2240">
                                        <rect key="frame" x="20" y="144" width="228" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="228" id="2291"/>
                                            <constraint firstAttribute="height" constant="21" id="2292"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="15"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="2291"/>
                                                <exclude reference="2292"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="2291"/>
                                                <include reference="2292"/>
                                            </mask>
                                        </variation>
                                    </label>
                                    <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="+ Select an organization" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="2241" customClass="PorpoiseEditText">
                                        <rect key="frame" x="20" y="173" width="335" height="30"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="335" id="2256"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits"/>
                                    </textField>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Sharing" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2331">
                                        <rect key="frame" x="20" y="253" width="254" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="254" id="2334"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" textAlignment="natural" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2335">
                                        <rect key="frame" x="20" y="282" width="236" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="236" id="2611"/>
                                            <constraint firstAttribute="height" constant="21" id="2612"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="scaleAspectFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Label" textAlignment="natural" lineBreakMode="clip" numberOfLines="0" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2579" customClass="PorpoiseLabel">
                                        <rect key="frame" x="20" y="285" width="276" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="276" id="2598"/>
                                            <constraint firstAttribute="height" relation="greaterThanOrEqual" constant="21" id="2602"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <switch opaque="NO" contentMode="scaleToFill" horizontalHuggingPriority="750" verticalHuggingPriority="750" selected="YES" contentHorizontalAlignment="center" contentVerticalAlignment="center" on="YES" translatesAutoresizingMaskIntoConstraints="NO" id="2585">
                                        <rect key="frame" x="304" y="280" width="51" height="31"/>
                                    </switch>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <accessibility key="accessibilityConfiguration">
                                    <accessibilityTraits key="traits" notEnabled="YES"/>
                                </accessibility>
                                <constraints>
                                    <constraint firstAttribute="width" constant="375" id="1831"/>
                                    <constraint firstItem="1843" firstAttribute="leading" secondItem="1827" secondAttribute="leading" constant="20" id="1848"/>
                                    <constraint firstItem="1843" firstAttribute="top" secondItem="1827" secondAttribute="top" id="1849"/>
                                    <constraint firstAttribute="trailing" secondItem="1868" secondAttribute="trailing" constant="11" id="1869"/>
                                    <constraint firstItem="1868" firstAttribute="top" secondItem="1827" secondAttribute="top" constant="29" id="1870"/>
                                    <constraint firstAttribute="height" constant="514" id="2238"/>
                                    <constraint firstAttribute="trailing" secondItem="2241" secondAttribute="trailing" constant="20" id="2254"/>
                                    <constraint firstItem="2241" firstAttribute="top" secondItem="1827" secondAttribute="top" constant="173" id="2255"/>
                                    <constraint firstItem="1836" firstAttribute="leading" secondItem="1827" secondAttribute="leading" constant="20" id="2285"/>
                                    <constraint firstItem="1836" firstAttribute="top" secondItem="1827" secondAttribute="top" constant="28" id="2286"/>
                                    <constraint firstItem="2240" firstAttribute="leading" secondItem="1827" secondAttribute="leading" constant="20" id="2289"/>
                                    <constraint firstItem="2240" firstAttribute="top" secondItem="1827" secondAttribute="top" constant="144" id="2290"/>
                                    <constraint firstItem="2331" firstAttribute="leading" secondItem="1827" secondAttribute="leading" constant="20" id="2332"/>
                                    <constraint firstAttribute="bottom" secondItem="2331" secondAttribute="bottom" constant="240" id="2333"/>
                                    <constraint firstItem="1836" firstAttribute="leading" secondItem="1827" secondAttribute="leading" constant="20" id="2385"/>
                                    <constraint firstItem="1836" firstAttribute="top" secondItem="1843" secondAttribute="bottom" constant="7" id="2388"/>
                                    <constraint firstItem="1868" firstAttribute="leading" relation="lessThanOrEqual" secondItem="1827" secondAttribute="leading" constant="115" id="2389"/>
                                    <constraint firstAttribute="trailing" secondItem="2585" secondAttribute="trailing" constant="22" id="2606"/>
                                    <constraint firstAttribute="bottom" secondItem="2585" secondAttribute="bottom" constant="203" id="2607"/>
                                    <constraint firstItem="2335" firstAttribute="leading" secondItem="1827" secondAttribute="leading" constant="20" id="2609"/>
                                    <constraint firstAttribute="bottom" secondItem="2335" secondAttribute="bottom" constant="211" id="2610"/>
                                    <constraint firstItem="2579" firstAttribute="top" secondItem="2335" secondAttribute="top" constant="3" id="2615"/>
                                    <constraint firstItem="2579" firstAttribute="leading" secondItem="2331" secondAttribute="leading" id="2616"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="constraints">
                                        <exclude reference="2285"/>
                                        <exclude reference="2286"/>
                                        <exclude reference="2289"/>
                                        <exclude reference="2290"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="constraints">
                                        <include reference="2285"/>
                                        <include reference="2286"/>
                                        <include reference="2289"/>
                                        <include reference="2290"/>
                                    </mask>
                                </variation>
                            </view>
                            <view hidden="YES" contentMode="scaleToFill" ambiguous="YES" translatesAutoresizingMaskIntoConstraints="NO" id="wil-WO-WVg">
                                <rect key="frame" x="0.0" y="0.0" width="375" height="667"/>
                                <subviews>
                                    <activityIndicatorView opaque="NO" contentMode="scaleToFill" horizontalHuggingPriority="750" verticalHuggingPriority="750" fixedFrame="YES" animating="YES" style="gray" translatesAutoresizingMaskIntoConstraints="NO" id="MzK-PC-DM4">
                                        <rect key="frame" x="178" y="328" width="20" height="20"/>
                                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                                    </activityIndicatorView>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="0.74528556030000004" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="width" relation="greaterThanOrEqual" constant="375" id="2535"/>
                                    <constraint firstAttribute="height" relation="greaterThanOrEqual" constant="667" id="2536"/>
                                </constraints>
                                <variation key="default">
                                    <mask key="subviews">
                                        <exclude reference="MzK-PC-DM4"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=compact">
                                    <mask key="subviews">
                                        <include reference="MzK-PC-DM4"/>
                                    </mask>
                                </variation>
                                <variation key="heightClass=regular-widthClass=regular">
                                    <mask key="subviews">
                                        <include reference="MzK-PC-DM4"/>
                                    </mask>
                                </variation>
                            </view>
                        </subviews>
                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstItem="1726" firstAttribute="bottom" secondItem="1825" secondAttribute="top" constant="20" id="1832"/>
                            <constraint firstItem="1825" firstAttribute="leading" secondItem="1824" secondAttribute="leading" id="1833"/>
                            <constraint firstItem="1825" firstAttribute="bottom" secondItem="1827" secondAttribute="top" constant="1" id="1834"/>
                            <constraint firstItem="1827" firstAttribute="leading" secondItem="1824" secondAttribute="leading" id="1835"/>
                            <constraint firstAttribute="trailing" secondItem="wil-WO-WVg" secondAttribute="trailing" id="2533"/>
                            <constraint firstAttribute="bottom" secondItem="wil-WO-WVg" secondAttribute="bottom" id="2534"/>
                            <constraint firstItem="wil-WO-WVg" firstAttribute="leading" secondItem="1827" secondAttribute="leading" id="2537"/>
                            <constraint firstItem="wil-WO-WVg" firstAttribute="top" secondItem="1825" secondAttribute="top" id="2538"/>
                        </constraints>
                    </scrollView>
                    <connections>
                        <outlet property="DateSelection" destination="2206" id="name-outlet-2206"/>
                        <outlet property="OrganisationLabel" destination="2240" id="name-outlet-2240"/>
                        <outlet property="OrganisationSelection" destination="2241" id="name-outlet-2241"/>
                        <outlet property="Overlay" destination="wil-WO-WVg" id="name-outlet-wil-WO-WVg"/>
                        <outlet property="UploadedImage" destination="1836" id="name-outlet-1836"/>
                        <outlet property="contributionLabel" destination="2191" id="name-outlet-2191"/>
                        <outlet property="dateLabel" destination="2201" id="name-outlet-2201"/>
                        <outlet property="highlight" destination="1868" id="name-outlet-1868"/>
                        <outlet property="leftConstraint" destination="2389" id="name-outlet-2389"/>
                        <outlet property="metricLabel" destination="2192" id="name-outlet-2192"/>
                        <outlet property="shareLabel" destination="2335" id="name-outlet-2335"/>
                        <outlet property="surveyLabel" destination="2579" id="name-outlet-2579"/>
                        <outlet property="tellusaboutLabel" destination="1843" id="name-outlet-1843"/>
                        <outlet property="topHeader" destination="1825" id="name-outlet-1825"/>
                        <outlet property="unit" destination="2205" id="name-outlet-2205"/>
                        <outlet property="waiting" destination="MzK-PC-DM4" id="name-outlet-MzK-PC-DM4"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="1731" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="-1097" y="3496"/>
        </scene>
        <!--Challenge Log Hour View Controller-->
        <scene sceneID="1955">
            <objects>
                <tableViewController storyboardIdentifier="ChallengeLogHourViewController" id="1956" customClass="ChallengeLogHourViewController" sceneMemberID="viewController">
                    <tableView key="view" clipsSubviews="YES" contentMode="scaleToFill" alwaysBounceVertical="YES" dataMode="prototypes" style="plain" separatorStyle="default" rowHeight="44" sectionHeaderHeight="28" sectionFooterHeight="28" id="2015">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <view key="tableHeaderView" contentMode="scaleToFill" id="2042">
                            <rect key="frame" x="0.0" y="0.0" width="600" height="160"/>
                            <autoresizingMask key="autoresizingMask" flexibleMaxX="YES" flexibleMaxY="YES"/>
                            <subviews>
                                <view contentMode="scaleToFill" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="2101">
                                    <rect key="frame" x="393" y="0.0" width="375" height="101"/>
                                    <subviews>
                                        <imageView userInteractionEnabled="NO" contentMode="scaleToFill" horizontalHuggingPriority="251" verticalHuggingPriority="251" translatesAutoresizingMaskIntoConstraints="NO" id="dfv-eR-Olm">
                                            <rect key="frame" x="-12" y="-4" width="398" height="116"/>
                                            <constraints>
                                                <constraint firstAttribute="width" constant="398" id="2473"/>
                                                <constraint firstAttribute="height" constant="116" id="2474"/>
                                            </constraints>
                                            <variation key="default">
                                                <mask key="constraints">
                                                    <exclude reference="2473"/>
                                                    <exclude reference="2474"/>
                                                </mask>
                                            </variation>
                                            <variation key="heightClass=regular-widthClass=compact" image="ChallengeTopHeader.png">
                                                <mask key="constraints">
                                                    <include reference="2473"/>
                                                    <include reference="2474"/>
                                                </mask>
                                            </variation>
                                        </imageView>
                                        <label opaque="NO" userInteractionEnabled="NO" contentMode="scaleAspectFit" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Please select which challenge you wish to post toward" textAlignment="natural" lineBreakMode="wordWrap" numberOfLines="0" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="2076">
                                            <rect key="frame" x="20" y="40" width="335" height="41"/>
                                            <constraints>
                                                <constraint firstAttribute="width" constant="335" id="2104"/>
                                                <constraint firstAttribute="height" relation="greaterThanOrEqual" constant="21" id="2116"/>
                                            </constraints>
                                            <fontDescription key="fontDescription" type="system" pointSize="17"/>
                                            <color key="textColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                            <nil key="highlightedColor"/>
                                        </label>
                                    </subviews>
                                    <constraints>
                                        <constraint firstAttribute="trailing" secondItem="2076" secondAttribute="trailing" constant="20" id="2103"/>
                                        <constraint firstAttribute="width" constant="375" id="2107"/>
                                        <constraint firstAttribute="height" constant="101" id="2108"/>
                                        <constraint firstItem="2076" firstAttribute="top" secondItem="2101" secondAttribute="top" constant="40" id="2115"/>
                                        <constraint firstItem="dfv-eR-Olm" firstAttribute="leading" secondItem="2101" secondAttribute="leading" constant="-12" id="2471"/>
                                        <constraint firstAttribute="bottom" secondItem="dfv-eR-Olm" secondAttribute="bottom" constant="-11" id="2472"/>
                                    </constraints>
                                    <variation key="default">
                                        <mask key="constraints">
                                            <exclude reference="2471"/>
                                            <exclude reference="2472"/>
                                        </mask>
                                    </variation>
                                    <variation key="heightClass=regular-widthClass=compact">
                                        <mask key="constraints">
                                            <include reference="2471"/>
                                            <include reference="2472"/>
                                        </mask>
                                    </variation>
                                </view>
                                <searchBar contentMode="redraw" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="2109">
                                    <rect key="frame" x="413" y="103" width="335" height="44"/>
                                    <constraints>
                                        <constraint firstAttribute="width" constant="335" id="2112"/>
                                    </constraints>
                                    <textInputTraits key="textInputTraits"/>
                                </searchBar>
                            </subviews>
                            <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                            <constraints>
                                <constraint firstAttribute="trailing" secondItem="2101" secondAttribute="trailing" id="2105"/>
                                <constraint firstItem="2101" firstAttribute="top" secondItem="2042" secondAttribute="top" id="2106"/>
                                <constraint firstAttribute="trailing" secondItem="2109" secondAttribute="trailing" constant="20" id="2110"/>
                                <constraint firstAttribute="bottom" secondItem="2109" secondAttribute="bottom" constant="13" id="2111"/>
                            </constraints>
                        </view>
                    </tableView>
                    <connections>
                        <outlet property="challengers" destination="2015" id="name-outlet-2015"/>
                        <outlet property="headerContainer" destination="2042" id="name-outlet-2042"/>
                        <outlet property="searchBar" destination="2109" id="name-outlet-2109"/>
                        <outlet property="topHeaderView" destination="2101" id="name-outlet-2101"/>
                    </connections>
                </tableViewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="1962" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="-101.8" y="3498.604"/>
        </scene>
        <!--Request Account View Controller-->
        <scene sceneID="2644">
            <objects>
                <viewController storyboardIdentifier="RequestAccountViewController" id="2645" customClass="RequestAccountViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="2642"/>
                        <viewControllerLayoutGuide type="bottom" id="2643"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="2646">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <view contentMode="scaleToFill" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="d6K-kA-93D">
                                <rect key="frame" x="229" y="344" width="311" height="337"/>
                                <subviews>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Request an account" textAlignment="center" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="zKL-Mi-rjm">
                                        <rect key="frame" x="20" y="56" width="271" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="271" id="2863"/>
                                            <constraint firstAttribute="height" constant="21" id="2864"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="26"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="Full Name" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="aAt-g6-3Kg">
                                        <rect key="frame" x="63" y="97" width="220" height="30"/>
                                        <color key="backgroundColor" red="0.94363540410995483" green="0.9436575174331665" blue="0.9436456561088562" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <color key="tintColor" red="0.9968915581703186" green="0.99691492319107056" blue="0.99690228700637817" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="220" id="2705"/>
                                            <constraint firstAttribute="height" constant="30" id="2706"/>
                                            <constraint firstAttribute="height" constant="30" id="2818"/>
                                            <constraint firstAttribute="width" constant="220" id="2819"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits"/>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="2705"/>
                                                <exclude reference="2706"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="2705"/>
                                                <include reference="2706"/>
                                            </mask>
                                        </variation>
                                    </textField>
                                    <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="Company" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="aAn-8S-b2j">
                                        <rect key="frame" x="63" y="135" width="220" height="30"/>
                                        <color key="backgroundColor" red="0.94363540410995483" green="0.9436575174331665" blue="0.9436456561088562" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <color key="tintColor" red="0.9968915581703186" green="0.99691492319107056" blue="0.99690228700637817" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="220" id="2709"/>
                                            <constraint firstAttribute="height" constant="30" id="2710"/>
                                            <constraint firstAttribute="width" constant="220" id="2823"/>
                                            <constraint firstAttribute="height" constant="30" id="2824"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits"/>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="2709"/>
                                                <exclude reference="2710"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="2709"/>
                                                <include reference="2710"/>
                                            </mask>
                                        </variation>
                                    </textField>
                                    <textField opaque="NO" clipsSubviews="YES" contentMode="scaleToFill" contentHorizontalAlignment="left" contentVerticalAlignment="center" borderStyle="roundedRect" placeholder="Your work email" minimumFontSize="17" translatesAutoresizingMaskIntoConstraints="NO" id="sam-9N-TB7">
                                        <rect key="frame" x="63" y="173" width="220" height="30"/>
                                        <color key="backgroundColor" red="0.94363540410995483" green="0.9436575174331665" blue="0.9436456561088562" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <color key="tintColor" red="0.9968915581703186" green="0.99691492319107056" blue="0.99690228700637817" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="height" constant="30" id="2713"/>
                                            <constraint firstAttribute="width" constant="220" id="2714"/>
                                            <constraint firstAttribute="height" constant="30" id="2715"/>
                                            <constraint firstAttribute="width" constant="220" id="2827"/>
                                            <constraint firstAttribute="height" constant="30" id="2828"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="14"/>
                                        <textInputTraits key="textInputTraits"/>
                                        <variation key="default">
                                            <mask key="constraints">
                                                <exclude reference="2713"/>
                                                <exclude reference="2714"/>
                                                <exclude reference="2715"/>
                                            </mask>
                                        </variation>
                                        <variation key="heightClass=regular-widthClass=compact">
                                            <mask key="constraints">
                                                <include reference="2714"/>
                                                <include reference="2715"/>
                                            </mask>
                                        </variation>
                                    </textField>
                                    <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="Zev-T3-Cp8">
                                        <rect key="frame" x="49" y="257" width="92" height="30"/>
                                        <color key="backgroundColor" red="0.72336632013320923" green="0.72336632013320923" blue="0.72336632013320923" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="92" id="3461"/>
                                        </constraints>
                                        <state key="normal" title="Back">
                                            <color key="titleShadowColor" red="0.57230675220489502" green="0.57230675220489502" blue="0.57230675220489502" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        </state>
                                    </button>
                                    <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="Zvw-GW-q6k">
                                        <rect key="frame" x="192" y="257" width="92" height="30"/>
                                        <color key="backgroundColor" red="0.0" green="0.99143940210342407" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="92" id="3474"/>
                                        </constraints>
                                        <state key="normal" title="Submit">
                                            <color key="titleShadowColor" red="0.57230675220489502" green="0.57230675220489502" blue="0.57230675220489502" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        </state>
                                    </button>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="width" constant="311" id="3409"/>
                                    <constraint firstAttribute="height" constant="337" id="3410"/>
                                    <constraint firstItem="zKL-Mi-rjm" firstAttribute="top" secondItem="d6K-kA-93D" secondAttribute="top" constant="56" id="3411"/>
                                    <constraint firstItem="zKL-Mi-rjm" firstAttribute="leading" secondItem="d6K-kA-93D" secondAttribute="leading" constant="20" id="3412"/>
                                    <constraint firstItem="aAt-g6-3Kg" firstAttribute="top" secondItem="d6K-kA-93D" secondAttribute="top" constant="97" id="3413"/>
                                    <constraint firstItem="aAt-g6-3Kg" firstAttribute="leading" secondItem="d6K-kA-93D" secondAttribute="leading" constant="63" id="3414"/>
                                    <constraint firstItem="aAn-8S-b2j" firstAttribute="top" secondItem="d6K-kA-93D" secondAttribute="top" constant="135" id="3415"/>
                                    <constraint firstItem="aAn-8S-b2j" firstAttribute="leading" secondItem="d6K-kA-93D" secondAttribute="leading" constant="63" id="3416"/>
                                    <constraint firstAttribute="bottom" secondItem="sam-9N-TB7" secondAttribute="bottom" constant="134" id="3417"/>
                                    <constraint firstItem="sam-9N-TB7" firstAttribute="leading" secondItem="d6K-kA-93D" secondAttribute="leading" constant="63" id="3418"/>
                                    <constraint firstItem="Zev-T3-Cp8" firstAttribute="leading" secondItem="d6K-kA-93D" secondAttribute="leading" constant="49" id="3459"/>
                                    <constraint firstAttribute="bottom" secondItem="Zev-T3-Cp8" secondAttribute="bottom" constant="50" id="3460"/>
                                    <constraint firstItem="Zvw-GW-q6k" firstAttribute="centerY" secondItem="Zev-T3-Cp8" secondAttribute="centerY" id="3472"/>
                                    <constraint firstItem="Zvw-GW-q6k" firstAttribute="leading" secondItem="Zev-T3-Cp8" secondAttribute="trailing" constant="51" id="3473"/>
                                </constraints>
                            </view>
                        </subviews>
                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstItem="d6K-kA-93D" firstAttribute="centerY" secondItem="2646" secondAttribute="centerY" id="3431"/>
                            <constraint firstItem="d6K-kA-93D" firstAttribute="centerX" secondItem="2646" secondAttribute="centerX" id="3434"/>
                        </constraints>
                    </view>
                    <connections>
                        <outlet property="back" destination="Zev-T3-Cp8" id="name-outlet-Zev-T3-Cp8"/>
                        <outlet property="company" destination="aAn-8S-b2j" id="name-outlet-aAn-8S-b2j"/>
                        <outlet property="contentView" destination="d6K-kA-93D" id="name-outlet-d6K-kA-93D"/>
                        <outlet property="email" destination="sam-9N-TB7" id="name-outlet-sam-9N-TB7"/>
                        <outlet property="fullnamee" destination="aAt-g6-3Kg" id="name-outlet-aAt-g6-3Kg"/>
                        <outlet property="submit" destination="Zvw-GW-q6k" id="name-outlet-Zvw-GW-q6k"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="2647" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="783" y="2756"/>
        </scene>
        <!--Confirmation View Controller-->
        <scene sceneID="2651">
            <objects>
                <viewController storyboardIdentifier="ConfirmationViewController" id="2652" customClass="ConfirmationViewController" sceneMemberID="viewController">
                    <layoutGuides>
                        <viewControllerLayoutGuide type="top" id="2649"/>
                        <viewControllerLayoutGuide type="bottom" id="2650"/>
                    </layoutGuides>
                    <view key="view" contentMode="scaleToFill" id="2653">
                        <rect key="frame" x="0.0" y="0.0" width="600" height="600"/>
                        <autoresizingMask key="autoresizingMask" widthSizable="YES" heightSizable="YES"/>
                        <subviews>
                            <view contentMode="scaleToFill" misplaced="YES" translatesAutoresizingMaskIntoConstraints="NO" id="TrA-A7-0Be">
                                <rect key="frame" x="229" y="428" width="311" height="169"/>
                                <subviews>
                                    <label opaque="NO" userInteractionEnabled="NO" contentMode="left" horizontalHuggingPriority="251" verticalHuggingPriority="251" text="Thank you! We'll be in touch." textAlignment="center" lineBreakMode="tailTruncation" baselineAdjustment="alignBaselines" adjustsFontSizeToFit="NO" translatesAutoresizingMaskIntoConstraints="NO" id="VSW-eb-7Uk">
                                        <rect key="frame" x="20" y="52" width="271" height="21"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="271" id="3495"/>
                                            <constraint firstAttribute="height" constant="21" id="3496"/>
                                        </constraints>
                                        <fontDescription key="fontDescription" type="system" pointSize="20"/>
                                        <nil key="textColor"/>
                                        <nil key="highlightedColor"/>
                                    </label>
                                    <button opaque="NO" contentMode="scaleToFill" contentHorizontalAlignment="center" contentVerticalAlignment="center" buttonType="roundedRect" lineBreakMode="middleTruncation" translatesAutoresizingMaskIntoConstraints="NO" id="IGJ-z8-8Gg">
                                        <rect key="frame" x="105" y="105" width="104" height="39"/>
                                        <color key="backgroundColor" red="0.72336632013320923" green="0.72336632013320923" blue="0.72336632013320923" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        <constraints>
                                            <constraint firstAttribute="width" constant="104" id="tU0-BM-wnK"/>
                                            <constraint firstAttribute="height" constant="39" id="uIn-E6-DqB"/>
                                        </constraints>
                                        <state key="normal" title="Back to login">
                                            <color key="titleShadowColor" red="0.57230675220489502" green="0.57230675220489502" blue="0.57230675220489502" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                        </state>
                                    </button>
                                </subviews>
                                <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                                <constraints>
                                    <constraint firstAttribute="height" constant="169" id="3505"/>
                                    <constraint firstAttribute="width" constant="311" id="3506"/>
                                    <constraint firstItem="VSW-eb-7Uk" firstAttribute="top" secondItem="TrA-A7-0Be" secondAttribute="top" constant="52" id="3509"/>
                                    <constraint firstItem="VSW-eb-7Uk" firstAttribute="leading" secondItem="TrA-A7-0Be" secondAttribute="leading" constant="20" id="3510"/>
                                    <constraint firstItem="IGJ-z8-8Gg" firstAttribute="top" secondItem="VSW-eb-7Uk" secondAttribute="bottom" constant="32" id="3511"/>
                                    <constraint firstItem="IGJ-z8-8Gg" firstAttribute="leading" secondItem="TrA-A7-0Be" secondAttribute="leading" constant="105" id="3512"/>
                                </constraints>
                            </view>
                        </subviews>
                        <color key="backgroundColor" red="1" green="1" blue="1" alpha="1" colorSpace="custom" customColorSpace="sRGB"/>
                        <constraints>
                            <constraint firstItem="TrA-A7-0Be" firstAttribute="centerY" secondItem="2653" secondAttribute="centerY" id="3507"/>
                            <constraint firstItem="TrA-A7-0Be" firstAttribute="centerX" secondItem="2653" secondAttribute="centerX" id="3508"/>
                        </constraints>
                    </view>
                    <connections>
                        <outlet property="back" destination="IGJ-z8-8Gg" id="name-outlet-IGJ-z8-8Gg"/>
                        <outlet property="contentView" destination="TrA-A7-0Be" id="name-outlet-TrA-A7-0Be"/>
                    </connections>
                </viewController>
                <placeholder placeholderIdentifier="IBFirstResponder" id="2654" userLabel="First Responder" sceneMemberID="firstResponder"/>
            </objects>
            <point key="canvasLocation" x="1773" y="2262"/>
        </scene>
    </scenes>
    <resources>
        <image name="ChallengeTopHeader.png" width="393" height="162"/>
        <image name="LogPostPhotoHeaderBackground.png" width="393" height="137"/>
        <image name="camera_icon.png" width="44" height="44"/>
        <image name="clock_icon.png" width="44" height="44"/>
        <image name="left_arrow.png" width="44" height="44"/>
        <image name="right_arrow.png" width="44" height="44"/>
        <image name="Tabs/Selected/activity.png" width="25" height="25"/>
        <image name="Tabs/Selected/loghours.png" width="25" height="25"/>
        <image name="Tabs/Selected/profile.png" width="25" height="25"/>
        <image name="Tabs/Normal/activity.png" width="25" height="25"/>
        <image name="Tabs/Normal/loghours.png" width="25" height="25"/>
        <image name="Tabs/Normal/profile.png" width="25" height="25"/>
        <image name="thumbs_up.png" width="44" height="44"/>
        <image name="edit_pencil.png" width="44" height="44"/>
        <image name="thumbs_up_icon.png" width="64" height="64"/>
        <image name="play_button.png" width="44" height="44"/>
        <image name="ic_play_button.png" width="144" height="144"/>
        <image name="Tabs/Selected/settingsTools.png" width="28.333334" height="28.333334"/>
        <image name="Tabs/Normal/settingsTools.png" width="28.333334" height="28.333334"/>
        <image name="Logo_outline2.png" width="348" height="314"/>
        <image name="porpoise_background.png" width="1024" height="1366"/>
        <image name="Tabs/Normal/support.png" width="28.333334" height="28.333334"/>
        <image name="Tabs/Selected/support.png" width="30" height="30"/>
        <image name="Tabs/Normal/activityIcon.png" width="34" height="34"/>
        <image name="Tabs/Normal/iconProfile.png" width="34" height="34"/>
        <image name="Tabs/Normal/intercom.png" width="34" height="34"/>
        <image name="Tabs/Normal/plusIcon.png" width="34" height="34"/>
        <image name="Tabs/Normal/profileBarIcon.png" width="112" height="112"/>
        <image name="Tabs/Normal/profileImage.png" width="50" height="50"/>
        <image name="Tabs/Normal/settings.png" width="34" height="34"/>
        <image name="delete.png" width="44" height="44"/>
        <image name="dotbutton.png" width="44" height="44"/>
        <image name="dots_1.png" width="66" height="66"/>
        <image name="dots.png" width="44" height="12"/>
        <image name="Entypo_d83d(0)_128.png" width="128" height="128"/>
        <image name="givenWelldones.png" width="44" height="44"/>
        <image name="linea_78(0)_44.png" width="44" height="44"/>
        <image name="linea_78(0)_66.png" width="66" height="66"/>
        <image name="noImage.png" width="44" height="44"/>
        <image name="pencil.png" width="44" height="44"/>
        <image name="thumbs.png" width="44" height="44"/>
        <image name="thumbs1.jpg" width="44" height="44"/>
        <image name="wellDoneGray.png" width="44" height="44"/>
        <image name="wellDoneOrange.png" width="44" height="44"/>
        <image name="PlayButton.png" width="798" height="798"/>
        <image name="logout.png" width="33" height="33"/>
        <image name="PORPOISEALONE.png" width="44" height="37"/>
        <image name="PORPOISEALONE .png" width="33" height="28"/>
        <image name="PorpoiseText.png" width="44" height="11"/>
        <image name="Next.png" width="67" height="26"/>
        <image name="Back.png" width="43" height="16"/>
        <image name="Post.png" width="36" height="16"/>
        <image name="Cancel.png" width="56" height="16"/>
        <image name="PorpoiseLeftBar.png" width="102" height="22"/>
        <image name="Update.png" width="61" height="16"/>
        <image name="logo.png" width="53" height="44"/>
    </resources>
    <color key="tintColor" red="1" green="1" blue="1" alpha="0.59999999999999998" colorSpace="custom" customColorSpace="sRGB"/>
</document>